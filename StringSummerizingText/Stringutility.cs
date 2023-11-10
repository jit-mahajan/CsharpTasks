using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSummerizingText
{
    public class Stringutility
    {
        

        public static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split();

            var totalCharecters = 0;

            var summaryWords = new List<string>();

            foreach(var word in words) { 
            
                summaryWords.Add(word);

                totalCharecters += word.Length - 1;

                if (totalCharecters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + ".......";
        }

    }
}
