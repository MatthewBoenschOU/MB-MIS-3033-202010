using System;
using System.Collections.Generic;
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

namespace IntroToWPFAttempt2
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

        private void BttnCalc_MouseEnter(object sender, MouseEventArgs e)
        {
            BttnCalc.Background = Brushes.Aqua;
        }

        private void BttnCalc_Click(object sender, RoutedEventArgs e)
        {
            string Name, Age;
            Name = TxtBxName.Text;
            Age = TxtBxBirthDate.Text;
                       

            DateTime BirthDate = Convert.ToDateTime(Age);
            var HowOld = DateTime.Now - BirthDate;
            int Old = Convert.ToInt32(HowOld.TotalDays / 365);

            MessageBox.Show($"Welcome {Name} who is {Old} years old");
        }

        private void BttnCalc_MouseLeave(object sender, MouseEventArgs e)
        {
            BttnCalc.Background = Brushes.Gray;
        }
    }
}
