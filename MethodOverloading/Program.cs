namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Add(9, -1);
            Add(1.1, 1.2);
            Add(1, 0, true);
        }
        public static int Add(int x, int y)
        {
            Console.WriteLine($"{x} added to {y} is equal to {x + y}");
         return x + y;
        }
        public static double Add(double x, double y)
        {
            Console.WriteLine($"{x} add to {y} is equal to {x + y}");
         return x + y;
        }
        public static string Add(int x, int y, bool isCheck)
        {
            var total = x + y;
            if (isCheck == true && total > 1)
            {
                 Console.WriteLine($"You have {total} dollars");
                return $"{total} dollars";
            }
            else if (isCheck == true && total == 1)
            {
                Console.WriteLine($"You have {total} dollar");
                return $"You have {total} dollar";
            }
            else if (isCheck == true && total < 1)
            {
                Console.WriteLine($"You have {total} cents");
                return ($"You have {total} cents");          
            }
            else
            {
                return total.ToString();
            }
        }
    }
}
