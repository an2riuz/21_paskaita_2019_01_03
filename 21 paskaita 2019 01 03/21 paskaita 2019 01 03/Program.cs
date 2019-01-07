using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_paskaita_2019_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> sarasas = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from skaicius in sarasas
                         where skaicius % 2 == 1
                         select skaicius;

            foreach (int skaicius in result)
            {
                Console.WriteLine("Nelyginis skaicius: " + skaicius);
            }

            var result1 = from skaicius in sarasas
                          where skaicius % 5 == 0
                          select skaicius;

            foreach (int skaicius in result1)
            {
                Console.WriteLine("Dalijasi is 5: " + skaicius);
            }

            var result2 = sarasas.Where(skaicius => skaicius.Equals(7));

            foreach (int skaicius in result2)
            {
                Console.WriteLine("Ar yra septyni: " + skaicius);
            }

            var result3 = from skaicius in sarasas
                          where skaicius % 2 == 0
                          select skaicius;

            foreach (int skaicius in result3)
            {
                
            }

            var result5 = from skaicius in sarasas
                          where skaicius > 4 && skaicius < 8
                          select skaicius * skaicius;

            foreach (int skaicius in result5)
            {
                Console.WriteLine("Skaiciai kvadratu: " + skaicius);
            }

            var result6 = from skaicius in sarasas
                          where skaicius > 4 && skaicius < 8
                          select skaicius;

            Console.WriteLine("Suma: " + result6.Sum());
            Console.WriteLine("Vidurkis: " + result6.Average());
            */

            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Tas pats objektas!");
            }

            // Proxy
            Proxy myProxy = new Proxy(new RealObject());
            myProxy.DoStuff();

            // Command
            MyCommand testCommand = new MyCommand();
            testCommand.Execute();

            // HTTP


            Console.ReadKey();

        }
    }
}
