using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Administrative_Module am = new Administrative_Module();
            this.Close();
            am.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string w = cb.Text;

            Word aux_word = (this.DataContext as Autocomplete).SearchWord(w);

            string rm_line = aux_word.text + "," + aux_word.category + "," + aux_word.description + "," + aux_word.picture_path;
            Console.WriteLine(rm_line);

            var tempFile = @"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile2.txt";
            var linesToKeep = File.ReadLines(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt").Where(l => l != rm_line);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt");
            File.Move(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile2.txt", @"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt");

            FileStream fs = new FileStream(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt", FileMode.Open, FileAccess.ReadWrite);
            fs.SetLength(fs.Length - 1);
            fs.Close();

        }
    }
}
