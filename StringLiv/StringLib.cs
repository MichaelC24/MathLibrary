using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace StringLiv
{
    public class StringLib
    {
        public string Concat(string a, string b)
        {
            return $"{a} {b}";
        }
        public string Upper(string a)
        {
            return a.ToUpper();

        }
        public static string EveryOther(string a)
        {
            var toUpper = true;
            var converted = string.Empty;

            foreach (var c in a.ToCharArray())
            {//makes the input an array of characters
                if (!char.IsLetter(c)) //checks to make sure its not a symbol like !,@,#,$,%,...
                                       //ALSO ! in the beginning of the if there is an ! so if it equals false meaning its a symbol it does what right below
                {
                    converted += c;
                    continue;
                }
                if (toUpper)
                {
                    converted += c.ToString().ToUpper();
                }
                else
                {
                    converted += c.ToString().ToLower();
                    
                }
                    toUpper = !toUpper; //flips from what ever it currently is so true to false or false to true.
            }
                return converted;
        }
    }
}