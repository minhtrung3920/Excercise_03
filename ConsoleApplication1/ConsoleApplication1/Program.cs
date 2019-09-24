using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("helloo");

            Hline(5, 'b'); Console.WriteLine();

            Hline(6, 'a'); Console.WriteLine();
            Dline(10, 'g'); Console.WriteLine();
            
        }
        static void Hline(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.Write(c);
        }
        static void Dline(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Hline(i, '*');
            Console.Write(c);
        }

        //fir line : n- 1 spaces, 1 star
        // sec line: n-2 spaces, 1 star,  1 star, 1 star
        //third line: n-3 spaces, 1 star, 3 spaces, 1 star
        // four line: n-4 spaces, 1star, 4 space, 1 star
        //last: 2n-1 spaces stars


        static void DrawTriangle(int n, char c) 
    {
        //first line
        Hline(n - 1, ' '); 
        Hline(1, c );
        Console.WriteLine();

            int a = 1; int b = 2;
            Hline(n - a,' ');
            Hline(n - b,' ');
        
        for (int i = 0; i < n; i++)



        Hline(2 * n - 1, '*');
        Console.WriteLine();
    }

    }
}
