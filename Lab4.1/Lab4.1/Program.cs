namespace Lab4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window win = new Window(1,2);
            ListBox lsb = new ListBox(3,4,"Stand alone listbox");
            Button btn = new Button(5,6);
            win.DrawWindow();
            lsb.DrawWindow();
            btn.DrawWindow();
            Window[] winArr = new Window[3];
            winArr[0] = new Window(1,2);
            winArr[1] = new ListBox(3, 4, "List box in array");
            winArr[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArr[i].DrawWindow();
            }
        }
    }
}
