using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // CITIREA UNUI CARACTER
            char caracter;
            Console.WriteLine("APASATI O TASTA, APOI ENTER!");
            caracter = (char)Console.Read();
            Console.WriteLine("AI TASTAT: " + caracter);

            //  FACTORIAL
            long factorial; int n, i; 
            factorial = n = i = 1;
            n = Convert.ToInt16(Console.ReadLine());
            while (i++ < n)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("{0}! = {1}", n, factorial);
            
            // INSTRUCTIUNEA if
            /**char ch, rasp = 'A';
            Console.WriteLine("Introduceti un caracter");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == rasp)
            {
                Console.WriteLine("Raspuns corect");
            }
            else
            {
                Console.WriteLine("Raspuns gresit");
            }
            **/
        }
    }
}

