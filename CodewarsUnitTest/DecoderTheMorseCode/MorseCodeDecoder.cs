using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.DecoderTheMorseCode
{
    class MorseCodeDecoder
    {
        /*
        A	.-	
        B	-...	
        C	-.-.	
        D	-..	
        E	.	
        F	..-.	
        G	--.
        H	....	
        I	..	
        J	.---	
        K	-.-	
        L	.-..	
        M	--	
        N	-.
        O	---	
        P	.--.	
        Q	--.-	
        R	.-.	
        S	...	
        T	-	
        U	..-
        V	...-	
        W	.--	
        X	-..-	
        Y	-.--	
        Z	--..		
        */
        private static Dictionary<string, string> MorseCode = new Dictionary<string, string>();
        static MorseCodeDecoder()
        {
            MorseCode.Add(".-", "A");
            MorseCode.Add("-...", "B");
            MorseCode.Add("-.-.", "C");
            MorseCode.Add("-..", "D");
            MorseCode.Add(".", "E");
            MorseCode.Add("..-.", "F");
            MorseCode.Add("--.", "G");
            MorseCode.Add("....", "H");
            MorseCode.Add("..", "I");
            MorseCode.Add(".---", "J");
            MorseCode.Add("-.-", "K");
            MorseCode.Add(".-..", "L");
            MorseCode.Add("--", "M");
            MorseCode.Add("-.", "N");
            MorseCode.Add("-- -", "O");
            MorseCode.Add(".--.", "P");
            MorseCode.Add("--.-", "Q");
            MorseCode.Add(".-.", "R");
            MorseCode.Add("...", "S");
            MorseCode.Add("-", "T");
            MorseCode.Add("..-", "U");
            MorseCode.Add("...-", "W");
            MorseCode.Add(".--", "W");
            MorseCode.Add("-..-", "X");
            MorseCode.Add("-.--", "Y");
            MorseCode.Add("--..", "Z");
        }

        public static string Decode(string morseCode)
        {
            var words = morseCode.Split(new string[] {"   "}, StringSplitOptions.None)
                .Select(word => word.Split(new char[]{' '},StringSplitOptions.None))
                .Select(word => word.Select(morse => MorseCode[morse]).ToArray())
                .Select(word => string.Join("", word))
                .Where(word => word != string.Empty)
                .ToArray();

            return string.Join(" ", words);
        }
    }
}
