using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Singleton Pattern Demo
            //Singleton instance = Singleton.getInstance();
            //instance.print();
            //Console.Read();

            //Factory Pattern Demo
            PrinterFactoryPattern fp = new PrinterFactoryPattern();
            Console.WriteLine("Please enter either Color or bw to print");
            string input = Console.ReadLine();
            PrinterorScanner output = fp.printInput(input);
            output.printorscan();
            Console.Read();

            //Abstract Factory Pattern Demo
            AbstractFactoryPattern afp = new AbstractFactoryPattern();
            Console.WriteLine("Please enter either Scan or Print");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please enter either Color or bw");
            string input2 = Console.ReadLine();
            afp.printorscan(input1, input2);
            Console.Read();
        }
    }
}
