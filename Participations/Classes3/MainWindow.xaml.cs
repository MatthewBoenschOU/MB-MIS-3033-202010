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

namespace Classes3
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

        private void LB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SelectedStudent = (Address)LB.SelectedItem;
            StudentInfoWindow InfoWindow = new StudentInfoWindow();
            InfoWindow.sp = SelectedStudent;
            InfoWindow.Setup();
            InfoWindow.Show();
        }

        private void BttnAddToLB_Click(object sender, RoutedEventArgs e)
        {
            

            bool IsDoubleGPA = double.TryParse(TxtBxGPA.Text, out double G);
            bool IsIntZip = int.TryParse(TxtBxZipCode.Text, out int Z);
            bool IsIntSN = int.TryParse(TxtBxStreetNumber.Text, out int S);

            if (IsIntSN == false)
            {
                MessageBox.Show("Please Enter A Valid Street Number");
            }
            if (TxtBxStreetName.Text == "")
            {
                MessageBox.Show("Please Enter A Valid Street Name");
            }
            if (TxtBxState.Text == "")
            {
                MessageBox.Show("Please Enter A Valid State");
            }
            if (TxtBxCity.Text == "")
            {
                MessageBox.Show("Please Enter A Valid City");
            }
            if (IsIntZip == false)
            {
                MessageBox.Show("Please Enter A Valid Zip Code");
            }
            if (TxtBxFirstname.Text == "")
            {
                MessageBox.Show("Please Enter A Valid First Name");
            }
            if (TxtBxLastName.Text == "")
            {
                MessageBox.Show("Please Enter A Valid Last Name");
            }
            if (TxtBxMajor.Text == "")
            {
                MessageBox.Show("Please Enter A Valid Major");
            }
            if (IsDoubleGPA == false)
            {
                MessageBox.Show("Please Enter A Valid GPA");
            }



            Address NewAddress = new Address();
            NewAddress.StreetNumber = Convert.ToInt32(TxtBxStreetNumber.Text);
            NewAddress.StreetName = TxtBxStreetName.Text;
            NewAddress.State = TxtBxState.Text;
            NewAddress.City = TxtBxCity.Text;
            NewAddress.Zipcode = Convert.ToInt32(TxtBxZipCode.Text);

            Student NewStudent = new Student();
            NewStudent.FirstName = TxtBxFirstname.Text;
            NewStudent.LastName = TxtBxLastName.Text;
            NewStudent.Major = TxtBxMajor.Text;
            NewStudent.GPA = Convert.ToDouble(TxtBxGPA.Text);

            TxtBxStreetNumber.Text = "Please Enter Your Street Number";
            TxtBxStreetName.Text = "Please Enter Your Street Name";
            TxtBxState.Text = "Please Enter Your State";
            TxtBxCity.Text = "Please Enter Your City";
            TxtBxZipCode.Text = "Please Enter Your Zip Code";
            TxtBxFirstname.Text = "Please Enter Your First Name";
            TxtBxLastName.Text = "Please Enter Your Last Name";
            TxtBxMajor.Text = "Please Enter Your Major";
            TxtBxGPA.Text = "Please Enter Your GPA";



            LB.Items.Add($"{NewStudent.ToString()}");
        }
    }
}
