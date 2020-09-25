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

namespace WPFClasses2
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

        private void BttnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            bool IsDouble = double.TryParse(TxtBxPrice.Text, out double n);
                                    
                if (TxtBxName.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Toy Name");
                    
                    TxtBxName.Text = "Please Enter The Toys Name";
                }               
                if (TxtBxManufacturer.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Manufacturer Name");
                    
                    TxtBxManufacturer.Text = "Please Enter The Manufacturer Of The Toy";
                }               
                if (IsDouble == false)
                {
                    MessageBox.Show("Please Enter A Valid Price");
                                       
                }
                                                

            Toy NewToy = new Toy();
            NewToy.Name = TxtBxName.Text;
            NewToy.Price = Convert.ToDouble(TxtBxPrice.Text);
            NewToy.Manufacturer = TxtBxManufacturer.Text;

            LBToys.Items.Add($"{NewToy.Manufacturer} - {NewToy.Name}");
            string Aisle = NewToy.GetAisle();

            TxtBxName.Text = "Please Enter The Toys Name";
            TxtBxPrice.Text = "Please Enter The Price Of The Toy";
            TxtBxManufacturer.Text = "Please Enter The Manufacturer Of The Toy";

        }

        private void LBToys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy LBToy = (Toy)LBToys.SelectedItem;

            MessageBox.Show($"{LBToy.GetAisle()}");
             
        }
    }
}
