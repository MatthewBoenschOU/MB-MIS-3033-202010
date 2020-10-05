using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace ChuckNorris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Jokes JokeAPIResults;
            string APIURL = @"https://api.chucknorris.io/jokes/categories";

            using (var Client = new HttpClient())
            {
                string JsonResults = Client.GetStringAsync(APIURL).Result;
                string[] Categories = JsonConvert.DeserializeObject<string[]>(JsonResults);
                CBJokeCategories.Items.Add("all");
                foreach (var Cat in Categories)
                {
                    CBJokeCategories.Items.Add(Cat);
                }
            }
            
        }

        private void BttnGetJoke_Click(object sender, RoutedEventArgs e)
        {
            string SelectedCat = CBJokeCategories.SelectedItem.ToString();
            Jokes NewJoke = new Jokes();
            string AllUrl = @"https://api.chucknorris.io/jokes/random";
            string CatUrl = @"https://api.chucknorris.io/jokes/random?category=" + SelectedCat.ToLower();
            if (SelectedCat == "all")
            {
                using (var Client = new HttpClient())
                {
                    string JsonOut = Client.GetStringAsync(AllUrl).Result;
                    NewJoke = JsonConvert.DeserializeObject<Jokes>(JsonOut);
                    TxtBxJoke.Text = NewJoke.value;
                }
            }
            else
            {
                using (var Client = new HttpClient())
                {
                    string JsonOutPut = Client.GetStringAsync(CatUrl).Result;
                    NewJoke = JsonConvert.DeserializeObject<Jokes>(JsonOutPut);
                    TxtBxJoke.Text = NewJoke.value;
                }
            }

            

            

        }
    }
}
