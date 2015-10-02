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
        public Print(string Line)
        {
            line = Line;
        }
        List<string> words = new List<string>();
        private void skaidyk()
        {
            int n = line.Length;
            Console.WriteLine("n lygu {0}", n);
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine(i);
                string word="";
                switch (line[i])
                {
                    case ' ':
                        Console.WriteLine("SPACE");
                        break;
                    case '<':
                        Console.WriteLine("<");
                        break;
                    case '"':
                        for (int j = 1; j < n - i; j++)
                        {
                            if (line[i + j] == '"')
                            {
                                i += j;
                                break;
                            }
                            word += line[i + j];
                        }
                        break;
                    default:
                        for (int j = 1; j < n - i; j++)
                        {
                            if ((line[i + j] == ' ') || (line[i + j] == '<'))
                            {
                                i += j;
                                break;
                            }
                            word += line[i + j];
                        }
                        
                        break;
                }
                Console.WriteLine("wordd {0}", word);
                if (word != "") words.Add(word);
            }
        }
        public List<string> demenys()
        {
            skaidyk();
            Console.WriteLine(line.Length);
            return words;
        }
    }
}

