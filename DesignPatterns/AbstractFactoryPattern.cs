using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class AbstractFactoryPattern
    {
        public void printorscan(string input, string input1)
        {
            if(input == "Scan")
            {
                ScannerFactoryPattern sp = new ScannerFactoryPattern();
                PrinterorScanner ps = sp.scanByInput(input1);
                ps.printorscan();
            }
            else
            {
                PrinterFactoryPattern ps = new PrinterFactoryPattern();
                PrinterorScanner pos = ps.printInput(input1);
                pos.printorscan();
            }
        }
    }
}
