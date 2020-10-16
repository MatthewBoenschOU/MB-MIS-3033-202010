//Matthew Boensch
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
using System.Windows.Shapes;

namespace Classes3
{
    /// <summary>
    /// Interaction logic for StudentInfoWindow.xaml
    /// </summary>
    public partial class StudentInfoWindow : Window
    {
        
        public StudentInfoWindow()
        {
            InitializeComponent();
        }
        public void PopUpWindow(Student Stud)
        {

            string ShowName = $"{Stud.LastName} {Stud.FirstName}";
            LblStudentName.Content = ShowName;

            string ShowAddress = $"{Stud.Address.StreetNumber} {Stud.Address.StreetName}, {Stud.Address.City}, {Stud.Address.State}. {Stud.Address.Zipcode}";
            LblAddressInfo.Content = ShowAddress;



        }
    }
}
