using System;
using System.Threading.Tasks.Dataflow;

namespace A
{
    
    class Program
    {
        static void Ans()
        {
            for (int i = 1; i <= 20; i++)
            {
                for (int j = i + 1; j <= 20; j++)
                {
                    for (int k = j + 1; k <= 20; k++)
                    {

                        if (i * i + j * j == k * k)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                            Console.WriteLine($"{j} {i} {k}");
                        }


                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Ans();
        }
    }
}
