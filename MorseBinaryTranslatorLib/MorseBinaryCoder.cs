using System.Collections.Generic;
using System.Threading.Tasks;

namespace MorseBinaryTranslatorLib
{
    public class MorseBinaryCoder
    {

        private Dictionary<char, string> Definitions;

        public MorseBinaryCoder()
        {
            Definitions = new Dictionary<char, string>();
            DefineDictionary();
        }
        
        public string Translate(string text)
        {
            string translation = "";
            string letterBreak = "00";

            foreach (var character in text)
            {
                if (Definitions.ContainsKey(character))
                {
                    translation += Definitions[character];
                    translation += letterBreak;
                }
                else
                {
                    translation += "X";
                }

            }

            return translation;
        }

        private void DefineDictionary()
        {
            Definitions.Add('e', "10");
            Definitions.Add('t', "11");

            Definitions.Add(' ', "0000");
            Definitions.Add('a', "1011");
            Definitions.Add('m', "1111");
            Definitions.Add('n', "1110");
            Definitions.Add('i', "1010");

            Definitions.Add('d', "111010");
            Definitions.Add('g', "111110");
            Definitions.Add('k', "111011");
            Definitions.Add('r', "101110");
            Definitions.Add('s', "101010");
            Definitions.Add('u', "101011");
            Definitions.Add('w', "101111");
            Definitions.Add('o', "111111");

            Definitions.Add('b', "11101010");
            Definitions.Add('c', "11101110");
            Definitions.Add('f', "10101110");
            Definitions.Add('h', "10101010");
            Definitions.Add('j', "10111111");
            Definitions.Add('l', "10111010");
            Definitions.Add('p', "10111110");
            Definitions.Add('q', "11111011");
            Definitions.Add('v', "10101011");
            Definitions.Add('x', "11101011");
            Definitions.Add('y', "11101111");
            Definitions.Add('z', "11111010");

            Definitions.Add('1', "1011111111");
            Definitions.Add('2', "1010111111");
            Definitions.Add('3', "1010101111");
            Definitions.Add('4', "1010101011");
            Definitions.Add('5', "1010101010");
            Definitions.Add('6', "1110101010");
            Definitions.Add('7', "1111101010");
            Definitions.Add('8', "1111111010");
            Definitions.Add('9', "1111111110");
            Definitions.Add('0', "1111111111");
        }

        

    }
}
