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
using System.IO;

namespace WPF_FileProccessing
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

        private void BtnGetPride_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run r = new Run();


            var bookContents = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            r.Text = bookContents;
            r.Foreground = Brushes.BlanchedAlmond;
            r.Background = Brushes.BurlyWood;


            p.Inlines.Add(r);
            fd.Blocks.Add(p);
            RTXT1.Document = fd;


        }

        private void BtnGetSales_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\cart3515\Downloads\SalesJan2009.csv";
            var contents = File.ReadAllLines(path); //read files

            double sumOfPrices = 0;
            //loop for output since it is a collection
            for (int i = 1; i < contents.Length; i++)// doesnt contain column name
            {
                string row = contents[i];
                var pieces = row.Split(','); //splits characters on commas so that we output cleaner
                double price;
                double.TryParse(pieces[2], out price); //creates a check for sum
                sumOfPrices += price;

                lst1.Items.Add(pieces[1] + " - " + pieces[2]);
            }
            lst1.Items.Add($"The total is {sumOfPrices.ToString("C2")}");// outputs a sum
            //foreach (var item in contents) // contains the column names
            //{
            //    lst1.Items.Add(item);
            //}
          

    
        }
    }
}
