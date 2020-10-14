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
        public Address sp { get; set; }
        public StudentInfoWindow()
        {
            InitializeComponent();
        }
        public void Setup()
        {
            var SelectedStudent = sp;
            LblStreetNum.Content = sp.StreetNumber;
            LblStreetName.Content = sp.StreetName;
            LblState.Content = sp.State;
            LblCity.Content = sp.City;
            LblZip.Content = sp.Zipcode;
            

        }
    }
}
