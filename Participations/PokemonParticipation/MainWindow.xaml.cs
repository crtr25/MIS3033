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

namespace PokemonParticipation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object jsonConvert;

        public MainWindow()
        {
            InitializeComponent();
            string path = "https://pokeapi.co/api/v2/pokemon";
            AllPokemonAPI pokemonAPI;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(path).Result;
                pokemonAPI = JsonConvert.DeserializeObject<AllPokemonAPI>(json);
            }
            foreach (var pokie in pokemonAPI.results)
            {
                lsbAllPokemon.Items.Add(pokie);
            }

        }

        private void lsbAllPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sprites pokemonAPI;
            sprites selectedCharacter = (sprites)lsbAllPokemon.SelectedItem;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedCharacter.url).Result;
                pokemonAPI = JsonConvert.DeserializeObject<sprites>(json);
            }
            imgPokemon.Source = new BitmapImage(new System.Uri(selectedCharacter.front_default));


            txtName.Text = Convert.ToString(AllPokemonResult.height)
            txtHeight.Text
        }
    }
}
