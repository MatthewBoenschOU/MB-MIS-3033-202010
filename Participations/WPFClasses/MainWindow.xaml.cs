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

namespace WPFClasses
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

        private void BttnEnter_Click(object sender, RoutedEventArgs e)
        {
            EntryForm NewEntry = new EntryForm();
            NewEntry.Name = TxtBxName.Text;
            NewEntry.Address = TxtBxAddress.Text;
            NewEntry.ZipCode = Convert.ToInt32(TxtBxZip.Text);

            LBEntries.Items.Add(NewEntry);

            TxtBxName.Text = "Enter Name Here";
            TxtBxAddress.Text = "Enter Address Here";
            TxtBxZip.Text = "Enter ZipCode Here";
        }

        
    }
}
