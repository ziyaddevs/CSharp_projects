namespace RandomCoding
{
    class Coding
    {
        public static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
                System.Console.WriteLine(num);
            }
            catch (System.FormatException ex)
            {
                System.Console.WriteLine("Caught an exception: " + ex.Message);
            }


            // int number;
            // var result = int.TryParse("abc", out number);
            // if (result)
            // System.Console.WriteLine(number);
            // else
            // System.Console.WriteLine("Failed to parse number.");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1, 2));
            System.Console.WriteLine(calculator.Add(1, 2, 3));
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4));
        }


        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (System.ArgumentNullException ex)
            {
                System.Console.WriteLine("Caught an exception: " + ex.Message);
            }
        }
    }
}