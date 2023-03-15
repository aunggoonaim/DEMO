using System;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Hello, World!", 0, 1);

            double n1, n2;

            n1 = InputSection(1);

            Print(string.Empty, 0, 2);

            n2 = InputSection(2);

            Print("สรุปยอดทั้งหมด", 3, 0);
            Print($"จำนวนที่ 1 : {n1}", 1, 1);
            Print($"จำนวนที่ 2 : {n2}", 1, 1);
            Print($"รวม : {n1 + n2}", 1, 1);
            Print("Press Enter to continue...", 2, 0);

            Console.ReadKey();
        }

        private static double InputSection(int section)
        {
            do
            {
                Console.WriteLine($"จำนวนที่ {section}");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value))
                {
                    Console.WriteLine($"คุณเลือก เลข {value}");
                    return value;
                }
                else
                {
                    Console.WriteLine("{0}กรุณาพิมเป็นตัวเลข", Environment.NewLine);
                }
            } while (true);
        }

        private static void Print(string input, int tabStart = 0, int tabEnd = 0)
        {
            for (int i = 0; i < tabStart; i++)
            {
                Console.Write("{0}", Environment.NewLine);
            }
            Console.Write(input);
            for (int i = 0; i < tabEnd; i++)
            {
                Console.Write("{0}", Environment.NewLine);
            }
            Console.WriteLine();
        }
    }
}
