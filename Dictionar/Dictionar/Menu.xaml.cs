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

namespace Dictionar
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Search_Module sm = new Search_Module();
            this.Close();
            sm.Show();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Entertainment_Module em = new Entertainment_Module();
            this.Close();
            em.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Administrative_Module am = new Administrative_Module();
            this.Close();
            am.Show();
        }
    }
}
