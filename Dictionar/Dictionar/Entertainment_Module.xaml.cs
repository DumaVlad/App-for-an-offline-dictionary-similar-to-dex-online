using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Entertainment_Module.xaml
    /// </summary>
    public partial class Entertainment_Module : Window
    {
        public List<string> answears;
        public List<string> ranswears;
        public int numberOfQuestions = new int();
        private ObservableCollection<Word> ceva;
        public Entertainment_Module()
        {
            InitializeComponent();
            res.Visibility = System.Windows.Visibility.Hidden;
            ceva = new ObservableCollection<Word>();

            answears = new List<string>();
            ranswears = new List<string>();

            numberOfQuestions = 0;
            Random random = new System.Random();
            Autocomplete x = new Autocomplete();
            ceva = x.word_list;

            int value1 = random.Next(0, ceva.Count());
            Word aux_word = ceva[value1];
            ranswears.Add(aux_word.text);
            
            int value = random.Next(0, 2);
            
            if (value == 0)
            {
                des.Text = aux_word.description;
                des.Visibility = System.Windows.Visibility.Visible;
                lb.Content = "Descriere";
                img.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(aux_word.picture_path);
                lb.Content = "    Imagine";
                img.Visibility = System.Windows.Visibility.Visible;
                des.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = answ.Text;
            answears.Add(a);
            numberOfQuestions++;
            answ.Text = "";

            Random random = new System.Random();
            int value1 = random.Next(0, ceva.Count());

            Word aux_word = ceva[value1];
            ranswears.Add(aux_word.text);
            int value = random.Next(0, 2);

            if (value == 0)
            {
                des.Text = aux_word.description;
                des.Visibility = System.Windows.Visibility.Visible;
                lb.Content = "Description";
                img.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(aux_word.picture_path);
                lb.Content = "     Image";
                img.Visibility = System.Windows.Visibility.Visible;
                des.Visibility = System.Windows.Visibility.Hidden;
            }

            if (numberOfQuestions == 4)
            {
                next.Content = "Final joc";
            }

            if (numberOfQuestions == 5)
            {
                next.Visibility = System.Windows.Visibility.Hidden;
                des.Visibility = System.Windows.Visibility.Hidden;
                img.Visibility = System.Windows.Visibility.Hidden;
                answ.Visibility = System.Windows.Visibility.Hidden;
                lb.Visibility = System.Windows.Visibility.Hidden;
                res.Visibility = System.Windows.Visibility.Visible;
                string results = "";
                for(int index = 0; index< 5; index++)
                {
                    if (answears[index] == ranswears[index])
                        results += "Intrebarea " + (index+1) + ": Raspuns corect!" + "\n";
                    else
                        results += "Intrebarea " + (index+1) + ": Raspuns gresit!" + " Raspunsul corect este: " + ranswears[index] + "\n";
                }
                Console.WriteLine(results);
                res.Text = results;
            }
            
        }
    }
}
