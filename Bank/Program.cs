using System;
using Bank.Classes;
// See https://aka.ms/new-console-template for more information
namespace Bank
{
    class Program
    {
        static void Main(String[] args)
        {
            /* PrimaryAccount p = new PrimaryAccount();
             Console.WriteLine(p.addBalance(100));
             Console.WriteLine(p.addBalance(500));
             Console.WriteLine(p.addBalance(-10));
             Console.WriteLine(p.addBalance(-100));
             Console.WriteLine(p.display()); */

            ChildAccount[] c = new ChildAccount[2];
            for(int i = 0; i < c.Length; i++)
            {
                c[i] = new ChildAccount();
            }
            Console.WriteLine(c[1].addBalance(1000));
            Console.WriteLine(c[0].addBalance(1001));
            Console.WriteLine(c[0].display());
            Console.WriteLine(c[1].display());

        }
    }
}
