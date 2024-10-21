using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    internal class Chapter
    {
        private string _name;
        private string _content;
        
        public Chapter()
        {
            _name = "";
            _content = "";  
        }

        public Chapter(string name, string content)
        {
            this. _name = name;
            this. _content = content;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public override string ToString() 
        {
            return _name + "\n" + _content;
        }
    }
}
