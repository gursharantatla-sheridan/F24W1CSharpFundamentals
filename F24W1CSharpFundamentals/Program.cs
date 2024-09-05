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


            byte b = 121;

            var p = "5.5";

            Console.WriteLine(@"hello\nworld");


            int cars = 4, bikes = 7, trucks = 8;

            // string concatenation
            Console.WriteLine("I have " + cars + " cars, " + bikes + " bikes and " + trucks + " trucks");

            // string interpolation
            Console.WriteLine($"I have {cars} cars, {bikes} bikes and {trucks} trucks");


            string[] colors = { "Red", "Blue", "Yellow", "Green", "White" };

            foreach (var c in colors)
            {
                Console.WriteLine($"{c,10}");
            }


            int i = 5;
            int j = i;

            i++;


            Console.WriteLine("\n\n\n");


            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);

            c1.radius = 50;
            Console.WriteLine(c1.radius);

            Circle c2 = c1;
            //Circle c2 = new Circle();
            Console.WriteLine(c2.radius);

            c2.radius = 100;
            Console.WriteLine(c2.radius);
            Console.WriteLine(c1.radius);



            Console.WriteLine("\n\n");



            string s1 = "hello";
            string s2 = "world";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            s1 = s2;
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            s2 = "bbye";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }

    class Circle
    {
        public double radius;
    }
}
