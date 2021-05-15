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
using System.IO;

namespace Dictionar
{
    /// <summary>
    /// Interaction logic for Administrative_Module.xaml
    /// </summary>
    public partial class Administrative_Module : Window
    {
        public Administrative_Module()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show(); 
        }
        private void Add_word(object sender, RoutedEventArgs e)
        {

            Word newWord = (DataContext as Autocomplete).newWord;
            if(newWord.category == "" && newWord.text != "" && newWord.description != "") 
            {
                string newLine = "\n" + newWord.text + "," + newCat.Text + "," + newWord.description + "," + newWord.picture_path;
                File.AppendAllText(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt", newLine);
                (DataContext as Autocomplete).word_list.Add(new Word(newWord.text, newCat.Text, newWord.description, newWord.picture_path));
                (DataContext as Autocomplete).text_list.Add(newWord.text);
            }
            else
                if (newWord.text != "" && newWord.category != "" && newWord.description != "")
                {
                 string newLine = "\n" + newWord.text + "," + newWord.category + "," + newWord.description + "," + newWord.picture_path;
                    File.AppendAllText(@"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt", newLine);
                    (DataContext as Autocomplete).word_list.Add(new Word(newWord.text, newWord.category, newWord.description, newWord.picture_path));
                    (DataContext as Autocomplete).text_list.Add(newWord.text);
                }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Modify m = new Modify();
            this.Close();
            m.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Delete d = new Delete();
            this.Close();
            d.Show();
        }
    }
}
