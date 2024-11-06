namespace Sprint3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task00.Run();
            double num1 = 2.2;
            decimal num2 = 4.9m;
            Console.WriteLine($"Converted {num1} and {num2}, result: {MultiplyInt.MultiplyInts((int)num1, (int)num2)}");
            ParsingInput.ReadFromUserAndParse();
            */

            Pokemon.Catch();

            Pokemon clefairy = new Pokemon();
            Pokemon suicune = new Pokemon();
            Pokemon skeledirge = clefairy;

            Console.WriteLine(skeledirge.GetType());

            Console.WriteLine(Object.ReferenceEquals(clefairy, skeledirge));
            Console.WriteLine(Object.ReferenceEquals(clefairy, suicune));

            skeledirge.Name = "Skeledirge";

            Console.WriteLine(skeledirge.ToString());
            Console.WriteLine(suicune.ToString());

        }
    }
}
