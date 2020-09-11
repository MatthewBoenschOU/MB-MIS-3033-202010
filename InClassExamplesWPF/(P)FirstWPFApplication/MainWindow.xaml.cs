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

namespace _P_FirstWPFApplication
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

        private void TxtBxName_MouseEnter(object sender, MouseEventArgs e)
        {
            TxtBxName.Text = "";
        }

        private void TxtBxBirthDate_MouseEnter(object sender, MouseEventArgs e)
        {
            TxtBxBirthDate.Text = "";
        }

        private void TxtBxBirthDate_MouseLeave(object sender, MouseEventArgs e)
        {
            TxtBxBirthDate.Text = "";
        }

        private void BttnAgeCalc_MouseEnter(object sender, MouseEventArgs e)
        {
            BttnAgeCalc.Background = new SolidColorBrush(Color.FromArgb(100, 100, 100, 100));
        }

        private void BttnAgeCalc_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
