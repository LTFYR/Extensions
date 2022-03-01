using System;
using System.Linq;

namespace Extensions
{
       static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exTensiON claSSi staTIc OLMalIdiR");
        }
        public static string ToCapitalized(this string word)
        {
            word = word.ToLower();
            var text = word.Split(" ");

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "" || text[i] == " " || ListofWords().Contains(text[i]))

                    continue;

                text[i] = text[i].FirstLetterUpper();
                {
                    return string.Join(" ", text);
                }

              

            }
            return word;
        }
        private static string FirstLetterUpper(this string word)
        {

            return word?.First().ToString().ToUpper() + word?.Substring(1).ToLower();


        }
        private static string[] ListofWords()
        {
            return new[]
            {
                "ext","en","si","on","cla","si","sta","tic","olm","ali","dir"
            };
        }
    }
}
