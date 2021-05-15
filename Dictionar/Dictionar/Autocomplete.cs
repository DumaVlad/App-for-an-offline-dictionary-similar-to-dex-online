using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Dictionar
{
    class Autocomplete 
    {
        public ObservableCollection<Word> word_list { get; set; }
        public Word newWord { get; set; }
        public ObservableCollection<string> text_list { get; set; }
        public ObservableCollection<string> category_list { get; set; }
        public Autocomplete()
        {
            word_list = new ObservableCollection<Word>();
            category_list = new ObservableCollection<string>();
            text_list = new ObservableCollection<string>();
            newWord = new Word("", "", "", "");
            string path = @"C:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\TextFile1.txt";
            try
            {
                category_list.Add("Nicio categorie");
                string file_line;
                StreamReader sr = new StreamReader(path);
                while((file_line = sr.ReadLine()) != null)
                {
                    string[] word_info = file_line.Split(',');
                    word_list.Add(new Word(word_info[0], word_info[1], word_info[2],word_info[3]));
                    if(category_list.Contains(word_info[1]) == false)
                    {
                        category_list.Add(word_info[1]);
                    }
                    text_list.Add(word_info[0]);
                }
            }
            catch
            {
                Console.WriteLine("Cannot access file!");
            }
        }
        public Word SearchWord(string text)
        {
            foreach( Word val in word_list)
            {
                if (val.text == text)
                    return val;
            }
            return default;
        }
    }
}

