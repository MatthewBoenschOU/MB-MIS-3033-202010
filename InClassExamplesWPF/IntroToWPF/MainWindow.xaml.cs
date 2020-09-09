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

namespace IntroToWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtAge.Text = "";
            TxtName.Clear();
        }

        private void BttnGo_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You have entered the button", "Entered");
        }

        private void BttnGo_Click(object sender, RoutedEventArgs e)
        {
            string Name, Age;
            Name = TxtName.Text;
            Age = TxtAge.Text;

            int AgeAsNumber = Convert.ToInt32(Age);

            TxtAge.Clear();
            TxtName.Clear();

            DateTime BirthDate = Convert.ToDateTime(Name);
            var HowOld = DateTime.Now - BirthDate;
            int Old = Convert.ToInt32(HowOld.TotalDays / 365);


            MessageBox.Show($"Welcome {Name} who is {Age}");
        }
    }
}
