using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            // make it bigger by 10
            a = +10;
            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value
            e *= e;
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            bool bigger = f1 > f2;
            Console.WriteLine(bigger);

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            bigger = g2 * 2 > g1;
            Console.WriteLine(bigger);

            long h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)
            Console.WriteLine(h%11==0);

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            Console.WriteLine(i1>i2*i2);
            Console.WriteLine(i1 < i2 * i2 * i2);

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            Console.WriteLine(j%3==0 || j%5==0);

            string k = "Apple";
            //fill the k variable with its cotnent 4 times
            string temp = k;

            for (int i = 0; i < 3; i++)
            {
                k += temp;
            }
            Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}