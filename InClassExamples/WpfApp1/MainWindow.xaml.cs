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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string apiURL = "https://rickandmortyapi.com/api/character/";
            RickAndMortyAPIResult apiInfo;
            //get this next portion on exam but know how to use it
            using (var client = new HttpClient())
            {//async can break up a task into multiple parts and everyone can work on it at the same time
                string json = client.GetStringAsync(apiURL).Result;

                apiInfo = JsonConvert.DeserializeObject<RickAndMortyAPIResult>(json);


            }
            foreach (var character in apiInfo.results)
            {
                LSTCharacters.Items.Add(character);
            }


        }

        private void LSTCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultObject selectedCharacter = (ResultObject)LSTCharacters.SelectedItem;
            imgCharacter.Source = new BitmapImage(new System.Uri(selectedCharacter.image)); //get this on exame
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //    ResultObject selectedCharacter = (ResultObject)LSTCharacters.SelectedItem;
            //    wbCharacterInfo.Source = new System.Uri(selectedCharacter.image);
            //}
        }
    }
}
