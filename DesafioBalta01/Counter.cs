using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta01
{
    public static class Counter
    {
        public static int Words(string text)
        {
            return text.Split(' ').Length;
        }

        public static int Characters(string text)
        {
            return text.Length;
        }

        public static int Vowels(string text)
        {
            int count = 0;

            foreach(char i in text.ToUpper())
            {
                switch (i)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        count++;
                        break;                        
                }
            }

            return count;
        }

        public static int Consonant(string text)
        {
            int count = 0;

            foreach (char i in text.ToUpper())
            {
                switch (i)
                {
                    case 'A':
                        continue;
                    case 'E':
                        continue;
                    case 'I':
                        continue;
                    case 'O':
                        continue;
                    case 'U':
                        continue;
                }

                count++;
            }

            return count;
        }
    }
}
