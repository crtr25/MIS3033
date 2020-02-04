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

namespace WPF_Classes
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            EntryForm e1 = new EntryForm();
            e1.Name = txtName.Text;
            e1.Address = txtAddress.Text;
            e1.ZipCode = Convert.ToInt32(txtZip.Text);

            
            LSB1.Items.Add(e1);
        }
    }
}
