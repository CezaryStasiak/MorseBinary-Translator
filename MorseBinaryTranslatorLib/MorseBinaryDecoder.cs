using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MorseBinaryTranslatorLib
{
    public class MorseBinaryDecoder
    {
        private Dictionary<string, char> Definitions;

        public MorseBinaryDecoder()
        {
            Definitions = new Dictionary<string, char>();
            DefineDictionary();
        }

        public string Translate(string text)
        {
            StringBuilder translation = new StringBuilder("");
            int position = 0;
            string key = "";
            string currentBits = "";
            
            while (position + 1 < text.Length) {
                currentBits = text.Substring(position, 2);
                if (currentBits == "10" || currentBits == "11")
                {
                    key += currentBits;
                }
                else
                {
                    if (Definitions.ContainsKey(key))
                    {
                        translation.Append(Definitions[key]);
                        key = "";
                    }
                    if (position + 6 < text.Length)
                    {
                        if (text.Substring(position + 2, 2) == "00" && text.Substring(position + 4, 2) == "00")
                        {
                            translation.Append(" ");
                        }
                    }
                }
                
                position += 2;

            }
            return translation.ToString();
        }
        
        private void DefineDictionary()
        {
            Definitions.Add("10", 'e');
            Definitions.Add("11", 't');

            Definitions.Add("0000", ' ');
            Definitions.Add("1011", 'a');
            Definitions.Add("1111", 'm');
            Definitions.Add("1110", 'n');
            Definitions.Add("1010", 'i');

            Definitions.Add("111010", 'd');
            Definitions.Add("111110", 'g');
            Definitions.Add("111011", 'k');
            Definitions.Add("101110", 'r');
            Definitions.Add("101010", 's');
            Definitions.Add("101011", 'u');
            Definitions.Add("101111", 'w');
            Definitions.Add("111111", 'o');

            Definitions.Add("11101010", 'b');
            Definitions.Add("11101110", 'c');
            Definitions.Add("10101110", 'f');
            Definitions.Add("10101010", 'h');
            Definitions.Add("10111111", 'j');
            Definitions.Add("10111010", 'l');
            Definitions.Add("10111110", 'p');
            Definitions.Add("11111011", 'q');
            Definitions.Add("10101011", 'v');
            Definitions.Add("11101011", 'x');
            Definitions.Add("11101111", 'y');
            Definitions.Add("11111010", 'z');

            Definitions.Add("1011111111", '1');
            Definitions.Add("1010111111", '2');
            Definitions.Add("1010101111", '3');
            Definitions.Add("1010101011", '4');
            Definitions.Add("1010101010", '5');
            Definitions.Add("1110101010", '6');
            Definitions.Add("1111101010", '7');
            Definitions.Add("1111111010", '8');
            Definitions.Add("1111111110", '9');
            Definitions.Add("1111111111", '0');

            Definitions.Add("1011101110", ',');
            Definitions.Add("1110111011", '.');
            Definitions.Add("1111101011", '-');
            Definitions.Add("1110101011", '!');
        }
    }
}
