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

namespace APIProblem
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

        private void BTNabilities_Click(object sender, RoutedEventArgs e)
        {

            // 1st get input from user
            string input = pokemonTXT.Text;
            PokemonAPI pokemonClass;

            //1st is to connect to the internet
            using (HttpClient client = new HttpClient())
            {
                //third is to check to see if the input is valid
                var path = "https://pokeapi.co/api/v2/pokemon/{pokemonTXT.Text}";
                var json = client.GetStringAsync(path).Result;
                pokemonClass = JsonConvert.DeserializeObject<PokemonAPI>(json);

                if (json.IsSuccessStatusCode)
                {
                    
                    LSB1.Items.Add(pokemonClass.name);

                }
                else
                {
                    pokemonTXT.Text = "";
                    MessageBox.Show("Error, please try again");
                }
            }


           
           
            

   

        }
    }
}
