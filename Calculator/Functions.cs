namespace Calculator
{
    public static class Functions
    {
        public static int Add(int a, int b)
        {
            // add up the two numbers
            int sum = a + b;

            return sum;
        }

        public static int Subtract(int a, int b)
        {
            // subtract the two numbers
            int diff = a - b;

            return diff;
        }

        public static int Multiply(int a, int b)
        {
            // find the product of the two numbers
            int product = a * b;

            return product;
        }

        public static double Divide(int a, int b)
        {
            // divide b from a
            double quotient = (double)a / (double)b;

            return quotient;
        }
    }
}