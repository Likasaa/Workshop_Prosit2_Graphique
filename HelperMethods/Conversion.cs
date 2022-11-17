using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Prosit2_Graphique.HelperMethods
{
    class Conversion
    {
        public string Convert(string ChainToConvert, string Converted)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(ChainToConvert);
            for (int i = 0; i < ChainToConvert.Length; i++)
            {
                if (asciiBytes[i] < 123 && asciiBytes[i] > 96)
                {
                    int convertion = asciiBytes[i] - 32;
                    char character = (char)convertion;
                    Converted += character.ToString();
                }
                else
                {
                    char character = (char)asciiBytes[i];
                    Converted += character.ToString();
                }
            }
            Console.WriteLine(Converted);
            return Converted;
        }

    }
}
