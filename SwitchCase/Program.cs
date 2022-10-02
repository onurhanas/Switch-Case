using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int month= DateTime.Now.Month;
          switch (month)
          {
            case 1:
            Console.WriteLine("Ocak ayındasınız");
            break;
            case 10:
            Console.WriteLine("Ekim ayındasınız");
            break;

            
            default:
            Console.WriteLine("Yanlış veri girdiniz");
            break;

          }
          switch (month)

          {
            case 12:
            case 1:
            case 2:
            Console.WriteLine("Kış ayındasınız");
            break;
            case 9:
            case 10:
            case 11:
            Console.WriteLine("Sonbahar ayındasınız");
            break;
            
            default:
            break;
          }

        }
    }
}