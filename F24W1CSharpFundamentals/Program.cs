namespace F24W1CSharpFundamentals
{
    internal class Program
    {
        static int y;

        static void Main(string[] args)
        {
            int @float;
            int x;

            //Console.WriteLine(x);
            Console.WriteLine(y);

            double d = 5.5;
            float f = 5.5F;
            decimal m = 5.5M;
            long l = 45433432L;

            var p = "5.5";

            Console.WriteLine(@"hello\nworld");


            int cars = 4, bikes = 7, trucks = 8;

            // string concatenation
            Console.WriteLine("I have " + cars +" cars, " + bikes + " bikes and " + trucks + " trucks");

            // string interpolation
            Console.WriteLine($"I have {cars} cars, {bikes} bikes and {trucks} trucks");
        }
    }
}
