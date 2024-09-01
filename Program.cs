using System;

namespace csharplearning {
    class Program {
        public static int fibonacciRecurse(int i) {
            if (i <= 2) return i;

            return fibonacciRecurse(i-2) + fibonacciRecurse(i - 1);
        }
        
        static void Main(string[] args) {
            
            //grab the first arg and use that as the input for fibonacci thing.
            //Console.WriteLine(args);
            // for (int i = 0; i < args.Length; i++) {
            //     Console.WriteLine(args[i]);
            //     
            // }
            
            int fiboNum = 20;
            if (args.Length == 1) {
                fiboNum = int.Parse(args[0]);
            }

            Console.WriteLine(DateTime.Now + ": " + fibonacciRecurse(fiboNum));
        }
        
    }
}