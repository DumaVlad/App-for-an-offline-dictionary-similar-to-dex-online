using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionar
{
    class Word
    {
        public String text { get; set; }
        public String category { get; set; }
        public String description { get; set; }
        public String picture_path { get; set; }

        public Word(String newText, String newCategory, String newDescription, String newPicturePath)
        {
            this.text = newText;
            this.category = newCategory;
            this.description = newDescription;
            this.picture_path = newPicturePath;
        }
    }
}
