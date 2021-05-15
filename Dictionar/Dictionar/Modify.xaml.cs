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
    /// Interaction logic for Modify.xaml
    /// </summary>
    public partial class Modify : Window
    {
        
        public string modified_word { get; set; }
        public Modify()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Administrative_Module mn = new Administrative_Module();
            this.Close();
            mn.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Word w = (DataContext as Autocomplete).SearchWord(modified_word);

            string line = text.Text + "," + category.Text + "," + description.Text + "," + path.Text;


            string rm_line = w.text + "," + w.category + "," + w.description + "," + w.picture_path;
            Console.WriteLine(line);
            

            var tempFile = @"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile2.txt";
            var linesToKeep = File.ReadLines(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt").Where(l => l != rm_line);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt");
            File.Move(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile2.txt", @"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt");

            FileStream fs = new FileStream(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt", FileMode.Open, FileAccess.ReadWrite);
            fs.SetLength(fs.Length - 1);
            fs.Close();
            File.AppendAllText(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt", line);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string w = cb_modify.Text;
            modified_word = w;
            Word newWord = (DataContext as Autocomplete).SearchWord(w);
            text.Text = newWord.text;
            category.Text = newWord.category;
            description.Text = newWord.description;
            path.Text = newWord.picture_path;
        }
    }
}
