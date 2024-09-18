namespace RandomDrive
{
    internal class Program
    {
        static void Main()
        {
            int randomInt = Random.Shared.Next();
            Console.WriteLine(randomInt);
            int zeroToNine = Random.Shared.Next(10);
            Console.WriteLine(zeroToNine);
            int dieRoll = Random.Shared.Next(1, 7);
            Console.WriteLine(dieRoll);

            double randomDouble = Random.Shared.NextDouble();
            Console.WriteLine(randomDouble * 10);

        }
    }
}
