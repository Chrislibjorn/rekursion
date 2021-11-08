using System;

namespace rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            hanoi(4,"A","B","C");


            void move(string f,string t)
            {
                Console.WriteLine($"move disc from {f} to {t}!");
            }
            void hanoi(int n, string f,string h, string t)
            {
                if(n==0){
                    return;
                }
                else{
                hanoi(n-1,f,t,h);
                move(f,t);
                hanoi(n-1,h,f,t);
                }
            }
        }
    }
}
