using System;
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;

namespace A
{
    
    class Program
    {
        static long fast(long A, int n,ref bool flag)

        {
            if (n <= 0)
            {
                return 1;
            }
            long ans = 1;
            try
            {
                
                if (n % 2 == 0)
                {
                    ans = fast(A, n / 2, ref flag);
                    if (ans > long.MaxValue / 2) flag = true;
                    ans *= ans;
                }
                else
                {
                    long h = fast(A, n / 2, ref flag);
                    if (fast(A, n / 2, ref flag) > long.MaxValue / A) flag = true;
                    ans = h*A;
                }
            }
            catch (Exception)
            {
                flag = true;
                
            }
            return ans;

        }
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
            bool flag = false;
            long A = 9;
            int n = 2;
            long ans=fast(A, n, ref flag);
            if (flag)
            {
                Console.WriteLine("Ошибка");
            }
            else {
                Console.WriteLine(ans);
            }
        }
    }
}
