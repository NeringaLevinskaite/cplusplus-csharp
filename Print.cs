using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sutvarkyti cout eilutes į Console.Write();
namespace Bandymas_versti
{
    class Print
    {
        private string line;
        char[] delimiterChars = { ' ', '<'};
        //patobulinti
        public void write()
        {
            string[] words = line.Split(delimiterChars);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
