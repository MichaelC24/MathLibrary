namespace MathLibraryClass
{
    public static class Class1
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return (a - b);
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Cant divide by zero");
                return 0;
            }
            return a / b;
        }
        public static int Modulo(int a, int b)
        {
            return a - (a / b * b);
                ///b / a 
        }
        public static int Square(int a)
        {
            return a * a;
        }
        public static int Factorial(int a)
        {
                int sum = 1;
            for (int i = a; i > 1; i--)
            {
                sum *= i;

            }
            return sum;
        }
    }
}
