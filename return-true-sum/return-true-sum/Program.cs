using System;

namespace returntruesum
{
    class MainClass
    {

        /*
         * takes user integers and adds them. 
         * if it adds up to 30, it returns true. 
         * if not, it returns false
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers!");
            //convert string to integer
            int first = Int32.Parse(Console.ReadLine());
            int second = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("{0} and {1}", first, second);
            int sum = first + second;
            if (sum == 30)
                Console.WriteLine("true");
            else
                Console.WriteLine("False");

            Console.ReadLine();

        }
    }
}
