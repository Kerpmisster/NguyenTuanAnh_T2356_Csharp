using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    internal class Book
    {
        private string _name;
        private Chapter[] chapters;
        public Book() 
        {
        
        }

        public Book(string name, int n)
        {
            this._name = name;
            this.chapters = new Chapter[n];
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                
                    throw new ArgumentNullException();
                _name = value;  
            }
        }
        public Chapter this[int index]
        {
            get { 
                if (index < 0 || index > chapters.Length-1)
                    throw new ArgumentOutOfRangeException();
                return chapters[index];
            }
            set
            {
                if (index < 0 || index > chapters.Length - 1)
                    throw new ArgumentOutOfRangeException();
                chapters[index] = value;
            }
        }
        public Chapter this[string name] 
        {
            get
            {
                foreach (Chapter chapter in chapters)
                {
                    if(chapter.Name == name)
                        return chapter;
                    
                }
                return null;
            }
            set { chapters[name.Length] = value; }
        }
    }
}
