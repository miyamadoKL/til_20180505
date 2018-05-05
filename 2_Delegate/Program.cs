using System;

namespace _2_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print a table of addition");
            // PrintOperationTable(Add);
            PrintOperationTable((x, y) => x + y);

            Console.WriteLine("Print a table of multiplication");
            // PrintOperationTable(Multiply);
            PrintOperationTable((x, y) => x * y);
        }

        // public delegate int Operator(int x, int y);

        //public static void PrintOperationTable(Operator op)
        public static void PrintOperationTable(Func<int, int, int> op)
        {
            for (var x = 1; x < 4; ++x) {
                for (var y = 1; y < 4; ++y) {
                    Console.Write("{0, 3}", op(x, y));
                }
                Console.WriteLine();
            }
        }
        //public static int Add(int x, int y) { return x + y; }
        //public static int Multiply(int x, int y) { return x * y; }
    }
}
