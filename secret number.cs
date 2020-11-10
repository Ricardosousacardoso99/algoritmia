using System;

namespace secret_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int secretnumber = r.Next(0, 101);

            int palpit = int.Parse(Console.ReadLine());

            bool flag = true;

            while(flag)
            {
                if (palpit > secretnumber)
                {
                    Console.WriteLine("menor");

                }
               else if (palpit < secretnumber)
                {
                    Console.WriteLine("maior");
                }

                else if (palpit==secretnumber)
                {
                    flag = false;
                    Console.WriteLine("igual");
                    break;
                }
                  
                 palpit = int.Parse(Console.ReadLine());
            }
        }
    }
}
