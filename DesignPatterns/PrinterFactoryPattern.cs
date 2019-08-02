using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PrinterFactoryPattern
    {
        public PrinterorScanner printInput(string input)
        {
            if (input == "Color")
            {
                return new Color();
                
            }
            else
            {
                return new bw();            
            }
        }
    }

    public class Color : PrinterorScanner
    {
        public void printorscan()
        {
            Console.WriteLine("Color Printing the text");
        }
    }

    public class bw : PrinterorScanner
    {
        public void printorscan()
        {
            Console.WriteLine("b/w Printing the text");
        }
    }

}

