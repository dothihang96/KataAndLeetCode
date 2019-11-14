using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    //Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
    // Example
    // "This is an example!" ==> "sihT si na !elpmaxe"
    // "double  spaces"      ==> "elbuod  secaps"
    public class ReverseWords
    {

        public string GetReverseWords(string input)
        {
            switch (input)
            {
                case null :
                    return null;
                case "" :
                    return "String is empty";
                default:
                    var words = input.Split(' ');

                    foreach (var word in words)
                    {
                        if (word!="")
                        {
                            var chars = word.ToCharArray();
                            Array.Reverse(chars);
                            var wordInReverse = new string(chars);
                            input = input.Replace(word, wordInReverse);
                        }

                    }
                    return input;
            }
        }
    }
}
