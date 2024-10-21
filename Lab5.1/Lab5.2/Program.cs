namespace Lab5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { 
                {1,2,3},
                {4,5,6},
                {5,6,9},
                {6,7,8},
            };
            Console.WriteLine("Noi dung mang:");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= a.GetUpperBound(1); j++) 
                {
                    Console.WriteLine("{0}", a[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Cac phan tu co chi so hang bang chi so cot:");
            for(int i = 0;i < a.GetUpperBound(0); i++)
            {
                for (int j = 0;j <= a.GetUpperBound(1); j++)
                {
                    if(i == j)
                    {
                        Console.WriteLine("{0}", a[i, j]);
                    }
                }
            }
            Console.WriteLine("Cac phan tu lon nhat tren hang");
            for(int i = 0; i<=a.GetUpperBound(0) ; i++)
            {
                int max = a[i, 0];
                for (int j = 0;j<=a.GetUpperBound(1); j++)
                {
                    if (a[i, j] > max)
                        a[i, j] = max;
                }
                Console.WriteLine("Hang {0}:{1}",i,max) ;
            }
            printArray(a);
            printXY(a);
            maxRow(a);
        }
        static void printArray(int[,] a) 
        { 
            Console.WriteLine("Cac phan tu trong mang:");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.WriteLine("{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void printXY(int[,] a)
        {
            Console.WriteLine("Cac phan tu trong mang:");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                if(j == i)
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                else
                    Console.Write(" {0} ", " ");
                Console.WriteLine();
            }
        }
        static void maxRow(int[,] a)
        {
            Console.WriteLine("Cac phan tu trong mang:");
            int maxRow = 0;
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                maxRow = a[i,0];
                for (int j = 1; j <= a.GetUpperBound(1); j++)
                {
                    if (maxRow < a[i,j])
                    {
                        maxRow = a[i, j];
                    }
                   
                }
                Console.WriteLine("{0} : {1}",i, maxRow);
            }
        }
    }
}
