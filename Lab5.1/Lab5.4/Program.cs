namespace Lab5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Programming with Csharp",4);
            book[0] = new Chapter("Chapte 1", "Introduction to Csharp");
            book[1] = new Chapter("Chapte 2", "Datatype and Variables in Csharp");
            book[2] = new Chapter("Chapte 3", "Input and Output in Console Application");
            book[3] = new Chapter("Chapte 4", "Statements Conditions and Loops");
            Console.WriteLine("List of book:");
            Console.WriteLine(book.Name);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(book[i].Name);
            }
            Console.WriteLine("Detail of Chapter 3");
            Console.WriteLine(book["Chapter 3"]);
            Console.ReadLine();
        }
    }
}
