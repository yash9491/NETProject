using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ScannerFactoryPattern
    {
        public PrinterorScanner scanByInput(string input)
        {
            if (input == "Color")
                return new Colorscan();
            else
                return new bwscan();
        }
    }
    public interface PrinterorScanner
    {
        void printorscan();
    }

    public class Colorscan : PrinterorScanner
    {
        public void printorscan()
        {
            Console.WriteLine("Color Scanning the text");
        }
    }

    public class bwscan : PrinterorScanner
    {
        public void printorscan()
        {
            Console.WriteLine("b/w Scanning the text");
        }
    }
}
