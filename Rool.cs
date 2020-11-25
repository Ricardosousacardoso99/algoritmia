using System;

namespace Rool
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int p1;
            int p2;

            p1 = r.Next(1, 6);
            p2 = r.Next(1, 6);


            if(p1<p2)
            {
                Console.WriteLine("Win");
            }
            else if (p2<p1)
             {
                Console.WriteLine("Win");
            }
            else
            {
                Console.WriteLine("Empate");
            }
        }
    }
}
