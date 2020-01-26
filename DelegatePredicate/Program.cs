using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DelegatePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> ch = (sayi) =>
            {
                return sayi % 2 == 0;
            };
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-------------");
                Console.Write("Sayı giriniz: ");
                int sayii = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (ch(sayii))
                    Console.WriteLine("SAYI Çift");
                else
                    Console.WriteLine("Sayı TEKTİR");
            }
            catch (Exception exc)
            {

               Console.WriteLine(exc.ToString());
            }
            Console.ReadKey();
        }
    }
}
