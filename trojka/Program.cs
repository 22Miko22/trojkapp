using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojka
{
    internal class Program
    {
        static int getwalidnumber()
        {
            int number;
            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Błąd: prosze podać liczbe całkowitą większą od 0.");
                }
            }

        }
        static void Main(string[] args)
        {
          


            Console.WriteLine("Podaj pierwszą lcizę");
            int a = getwalidnumber();

            Console.WriteLine("Podaj  drugą lcizę");
            int b = getwalidnumber();

            Console.WriteLine("Podaj  trzecią lcizę");
            int c = getwalidnumber();

            int[] numbers = { a, b, c };
            Array.Sort(numbers);
            a = numbers[0];
            b = numbers[1];
            c = numbers[2];


            Console.WriteLine("Największa liczba (c) to: " + c);

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                Console.WriteLine("Podane liczby tworzą trójke pitagorujską ");
            }
            else
            {
                Console.WriteLine("Podane liczby nie tworzą trójke pitagorujską");
            }
             Console.ReadKey();
        }
    }
}
