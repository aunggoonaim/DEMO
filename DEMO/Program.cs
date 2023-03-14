using System;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");

            double N1,N2;

            do
            {
                Console.WriteLine("จำนวนที่ 1");
                string Text01 = Console.ReadLine();

                if (double.TryParse(Text01, out N1))
                {
                    Console.WriteLine($"คุณเลือก เลข {N1}");
                    break;
                }

                else
                {
                    Console.WriteLine("\nกรุณาพิมเป็นตัวเลข");
                }

            } while (true);

            Console.WriteLine("\n\n");

            do
            {
                Console.WriteLine("จำนวนที่ 2");
                string Text02 = Console.ReadLine();

                if (double.TryParse(Text02, out N2))
                {
                    Console.WriteLine($"คุณเลือก เลข {N2}");
                    break;
                }

                else
                {
                    Console.WriteLine("\nกรุณาพิมเป็นตัวเลข");
                }
                
            } while (true);

            Console.WriteLine($"\n\n\nสรุปยอดทั้งหมด\nจำนวนที่ 1 : {N1}\nจำนวนที่ 2 : {N2}\nรวม : {N1 + N2:F2}\n\nPress Enter to continue...");
            Console.ReadKey();
        }
    }
}
