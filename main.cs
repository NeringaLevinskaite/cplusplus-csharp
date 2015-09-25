using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bandymas_versti
{
    class Program
    {
        static void Main(string[] args)
        {
            string nuoroda=@"Z:\KTU\Vertėjas\bandymas.txt";
            string[] lines = File.ReadAllLines(nuoroda);
            foreach (string line in lines)
            {
                Print print = new Print(line);
                print.write();
            }
            Console.ReadKey(); 
        }
    }
}
