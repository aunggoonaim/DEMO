using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            int N1;
            int N2;

            do
            {
                Console.WriteLine("เลข 1");
                string Text01 = Console.ReadLine();

                if (int.TryParse(Text01, out N1))
                {
                    Console.WriteLine($"คุณเลือก เลข {N1}");
                    break;
                }
                else if (double.TryParse(Text01, out N1))
                {
                    Console.WriteLine($"คุณเลือก เลข {N1}");
                    break;
                }
                else
                {
                    Console.WriteLine("\nกรุณาพิมเป็นตัวเลข");
                }

            } while (true);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            do
            {
                Console.WriteLine("เลข 2");
                string Text02 = Console.ReadLine();

                if (int.TryParse(Text02, out N2))
                {
                    Console.WriteLine($"คุณเลือก เลข {N2}");
                    break;
                }

                else if (double.TryParse(Text02, out N2))
                {
                    Console.WriteLine($"คุณเลือก เลข {N2}");
                    break;
                }

                else
                {
                    Console.WriteLine("\nกรุณาพิมเป็นตัวเลข");
                }
                
            } while (true);

            Console.WriteLine($"\n\n\nยอดทั้งหมด\nเลข 1 : {N1}\nเลข 2 : {N2}\nรวม : {N1 + N2}\n\nPress Enter to continue...");
            Console.ReadKey();
        }
    }
}
