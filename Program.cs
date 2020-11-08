using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int counter = 0;
            int n = r.Next(100);
            int num;

            for(int i= 0; i<n; i++)
            {
                num = r.Next(101);

                if(num >50)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }    
    }
}
