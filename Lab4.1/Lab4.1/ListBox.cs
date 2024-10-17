using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    internal class ListBox : Window
    {
        private string listBoxContents; 
        public ListBox(int top, int left, string contents) 
            : base(top, left)
        {
            this.listBoxContents = contents;
        }
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Drawing String to the ListBox at {0} ", listBoxContents);
        }

    }
}
