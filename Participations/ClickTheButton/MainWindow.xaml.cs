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

namespace ClickTheButton
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

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Size availableSize = new Size(grdMain.ActualWidth - btnSubmit.ActualWidth, grdMain.ActualHeight - btnSubmit.ActualHeight);
            Random r1 = new Random();
            int y = Convert.ToInt32((mainW.ActualWidth - btnSubmit.ActualWidth) ) ;
            int x = Convert.ToInt32((mainW.ActualHeight - btnSubmit.ActualHeight));
            btnSubmit.Margin = new Thickness(r1.Next(y),r1.Next(x),0,0);
        

        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            lblInfo.Content = $"X: {e.GetPosition(grdMain).X} Y: {e.GetPosition(grdMain).Y}";
        }
    }
}
