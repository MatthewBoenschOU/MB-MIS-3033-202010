using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string FilePath;
        private void BttnSelectFile_Click(object sender, RoutedEventArgs e)
        {
            FilePath = TxtBxFilePath.Text;

            if (File.Exists(FilePath))
            {
                BttnProcess.IsEnabled = true;
                BttnSelectFile.IsEnabled = false;
                TxtBxFilePath.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Invalid File. Please try again", "ERROR", MessageBoxButton.OK);
                TxtBxFilePath.Text = "";
            }
        }

        private void BttnProcess_Click(object sender, RoutedEventArgs e)
        {
            var lines = File.ReadAllLines(FilePath);

            double sum = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                var pieces = lines[i].Split(',');
                double val = 0;
                bool success = double.TryParse(pieces[2], out val);
                if (success == false)
                {
                    MessageBox.Show("ERROR ON LINE " + i);
                }
                else
                {
                    sum += val;
                }
                LstBxLines.Items.Add(pieces[1]);
            } 
            MessageBox.Show($"The total sum of price is {sum.ToString("C2")}!");
        }

        private void LstBxLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
