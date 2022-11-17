using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Prosit2_Graphique.HelperMethods
{
    class Conversion
    {
        private int Convertion;
        private char Character;
        private byte[] AsciiBytes;
        public string Convert(string ChainToConvert, string Converted)
        {
            AsciiBytes = Encoding.ASCII.GetBytes(ChainToConvert);
            for (int i = 0; i < ChainToConvert.Length; i++)
            {
                if (AsciiBytes[i] < 123 && AsciiBytes[i] > 96)
                {
                    Convertion = AsciiBytes[i] - 32;
                    Character = (char)Convertion;
                    Converted += Character.ToString();
                }
                else
                {
                    Character = (char)AsciiBytes[i];
                    Converted += Character.ToString();
                }
            }
            Console.WriteLine(Converted);
            return Converted;
        }

    }
}
