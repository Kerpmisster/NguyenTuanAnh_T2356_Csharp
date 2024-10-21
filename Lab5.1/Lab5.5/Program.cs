using System.Text;

namespace Lab5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tạo ứng dụng C# và thực hiên những công việc sau.");
            int[] arrays = { 11, 21, -31, 43, 24, 55, -33, 32, 67, -98 };

            int chon = 0;

            do
            {
                
                menu();
                Console.Write("Mời bạn chọn");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1- Tìm phần tử nhỏ nhất của mảng.");
                        int min = minArray(arrays);
                        Console.WriteLine("Mim:{0}", min);
                        break;
                    case 2:
                        Console.WriteLine("2- Đảo ngược mảng.");
                        ReverseArray(arrays);
                        break;
                    case 3:
                        Console.WriteLine("3- Sắp xếp mảng tăng hoặc giảm.");
                        SortArray(arrays);
                        break;
                    case 4:
                        Console.WriteLine("4- Tìm phần tử là số nguyên tố.");
                        PrintPrime(arrays);
                        break;
                    case 5:
                        Console.WriteLine("5- In ra số lượng các số dương liên tiếp nhiều nhất.");
                        int max = MaxConsecutivePositiveCount(arrays);
                        Console.WriteLine("Max positive numberr" + max);
                        break;
                    case 6:
                        Console.WriteLine("6- Tính trung bình cộng các phần tử dương.");
                        double avg = arrays.Where(x => x > 0).Average();
                        Console.WriteLine($"Trung bình cộng các phần tử dương là: {avg}");
                        break;
                    case 7:
                        Console.WriteLine("7- Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không?.");
                        bool alternating = IsAlternatingPositiveNegative(arrays);
                        Console.WriteLine(alternating ? "Mảng có các phần tử đan xen âm dương." : "Mảng không có các phần tử đan xen âm dương.");
                        
                        break;
                    case 8:
                        Console.WriteLine("8- Kết thúc.");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng.");
                        break;
                }
            } while (true);

        }
        static void menu()
        {
            Console.WriteLine("1- Tìm phần tử nhỏ nhất của mang.\r\n" +
                "2- Đảo ngược mảng.\r\n" +
                "3- Sắp xếp mảng tăng hoặc giảm.\r\n" +
                "4- Tìm phần tử là số nguyên tố.\r\n" +
                "5- In ra số lượng các số dương liên tiếp nhiều nhất.\r\n" +
                "6- Tính trung bình cộng các phần tử dương.\r\n" +
                "7- kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không?.\r\n" +
                "8- Kết thúc\n");
        
        }
        static int minArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        static void ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine("Reverse:" + String.Join(" ", arr));
        }
        static void SortArray(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Sorted:{0}" + String.Join(" ", arr));
        }
        static void PrintPrime(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]) == true)
                {
                    Console.WriteLine("{0}", arr[i]);
                }
            }
            Console.WriteLine();
        }
        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2;  i <= Math.Sqrt(num); i++) 
            {
                if(num% i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int MaxConsecutivePositiveCount(int[] array)
        {
            int maxCount = 0, currentCount = 0;

            foreach (var num in array)
            {
                if (num > 0)
                {
                    currentCount++;
                    //if(currentCount> maxCount)
                    //{
                    //    maxCount = currentCount;
                    //}
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 0;
                }
            }
            return maxCount;
        }
        static bool IsAlternatingPositiveNegative(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i] > 0 && array[i - 1] > 0) || (array[i] < 0 && array[i - 1] < 0))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
