namespace Lab4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson staff = new Staff();
            object data = "Devmaster";
            staff.Update(data);
            staff.Delete(data);
            staff.Insert(data);
            staff.Display(data);
            IPerson std = new Student() { Id = "S10", Name = "TuanAnh", Age = 21, };
            std.Display(std);
        }
    }
}
