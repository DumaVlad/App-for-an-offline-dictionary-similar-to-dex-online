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

namespace Dictionar
{
    public partial class Search_Module : Window
    {
        
        public Search_Module()
        {
            InitializeComponent();
        }
        private void addItem(Word word)
        {
            TextBlock block = new TextBlock();

            block.Text = word.text;

            block.Margin = new Thickness(2, 3, 2, 3);
            block.Cursor = Cursors.Hand;

            block.MouseLeftButtonUp += (sender, e) =>
            {
                textBox.Text = (sender as TextBlock).Text;

                Word aux_word = (this.DataContext as Autocomplete).SearchWord(textBox.Text);
                descript.Text = aux_word.description;
                Picture.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(aux_word.picture_path);
            };

            block.MouseEnter += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.DarkTurquoise;  
            };

            block.MouseLeave += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.Transparent;
            };

            resultStack.Children.Add(block);
        }
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool found = false;
            var border = (resultStack.Parent as ScrollViewer).Parent as Border;
            var data = (this.DataContext as Autocomplete).word_list;
            var aux_word = (this.DataContext as Autocomplete).newWord;

            string query = (sender as TextBox).Text;

            if (query.Length == 0)
            {
                resultStack.Children.Clear();
                border.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                border.Visibility = System.Windows.Visibility.Visible;
            }

            resultStack.Children.Clear();

            foreach (var obj in data)
            {

                if (obj.text.ToLower().StartsWith(query.ToLower()) && aux_word.category == "Nicio categorie")
                {
                    addItem(obj);
                    found = true;
                }
                else
                    if(obj.text.ToLower().StartsWith(query.ToLower()) && obj.category == aux_word.category)
                    {
                        addItem(obj);
                        found = true;
                    }
            }

            if (!found)
            {
                resultStack.Children.Add(new TextBlock() { Text = "No results found." });
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
