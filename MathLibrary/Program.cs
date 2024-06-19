using MathLibraryClass;
using StringLiv;

namespace MathLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sl = new StringLib();
            var newStr = sl.Concat("Hello", "World");
            Console.WriteLine(newStr);

            var answer = Class1.Add(11,22);
            Console.WriteLine(answer);

            var divide = Class1.Divide(11,22);
            Console.WriteLine(divide);

            var subtract = Class1.Subtract(11,22);
            Console.WriteLine(subtract);

            var multiply= Class1.Multiply(11,22);
            Console.WriteLine(multiply);

            var modulo = Class1.Modulo(11,22);
            Console.WriteLine(modulo);
            Console.WriteLine(11%22);
            var fact = Class1.Factorial(5);
            Console.WriteLine(fact);

            
            Console.WriteLine(StringLib.EveryOther("te!st"));
            

        }
    }
}
