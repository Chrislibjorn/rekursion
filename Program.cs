using System;

namespace rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isParsable = Int32.TryParse(args[0],out number);
            if(isParsable)
            hanoi(number, "A", "B", "C");
            else
            {
                Console.WriteLine("use a whole number");
            }
            void move(string f, string t)
            {
                Console.WriteLine($"move disc from {f} to {t}!");
            }
            void hanoi(int n, string f, string h, string t)
            {
                if (n == 0)
                {
                    return;
                }
                else
                {
                    hanoi(n - 1, f, t, h);
                    move(f, t);
                    hanoi(n - 1, h, f, t);
                }
            }
        }
    }
}