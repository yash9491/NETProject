using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
        public static Singleton _instance = null;

        private Singleton()
        {

        }

        public void print()
        {
            Console.WriteLine("Singleton class print");
        }

        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                return _instance;
            }
            else
                return _instance;
        }
    }
}
