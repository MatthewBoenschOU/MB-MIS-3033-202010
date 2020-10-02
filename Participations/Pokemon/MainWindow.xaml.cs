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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PokemonAPI PokemonAPIResults;
            string APIURL = @"https://pokeapi.co/api/v2/pokemon?limit=1100&offset=0/";
            
            using (var Client = new HttpClient())
            {
                string JsonResults = Client.GetStringAsync(APIURL).Result;
                PokemonAPIResults = JsonConvert.DeserializeObject<PokemonAPI>(JsonResults);
            }
            List<AllResults> Poki = new List<AllResults>();
            foreach (var Poke in PokemonAPIResults.Results)
            {
                Poki.Add(Poke);
            }

            foreach (var Animal in Poki.OrderBy(x => x.name))
            {
                CBPokeName.Items.Add(Animal);
                
            }
            
        }

        private void CBPokeName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Starter = CBPokeName.SelectedItem.ToString();
            Stats Size = new Stats();            
            Size.Url = @"https://pokeapi.co/api/v2/pokemon/" + Starter.ToLower();

            using (var Client = new HttpClient())
            {
                string JSONOutput = Client.GetStringAsync(Size.Url).Result;
                Size = JsonConvert.DeserializeObject<Stats>(JSONOutput);
                TxtBxH.Text = Convert.ToString(Size.height);
                TxtBxW.Text = Convert.ToString(Size.weight);
                var UriF = new Uri(Size.sprites.front_default);
                var FSprite = new BitmapImage(UriF);
                ImgFront.Source = FSprite;            
            }
            

            



        }

        private void BttnPicChange_Click(object sender, RoutedEventArgs e)
        {
            string Starter = CBPokeName.SelectedItem.ToString();
            Stats Size = new Stats();
            Size.Url = @"https://pokeapi.co/api/v2/pokemon/" + Starter.ToLower();
            
            

            using (var Client = new HttpClient())
            {
                string JSONOutput = Client.GetStringAsync(Size.Url).Result;
                Size = JsonConvert.DeserializeObject<Stats>(JSONOutput);
                TxtBxH.Text = Convert.ToString(Size.height);
                TxtBxW.Text = Convert.ToString(Size.weight);
                var UriB = new Uri(Size.sprites.back_default);
                var BSprite = new BitmapImage(UriB);
                ImgBack.Source = BSprite;
            }
            ImgFront.IsEnabled = false;
            


        }
    }
}
