namespace Lab_Algorithms_and_BigONotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithms myAlgos = new Algorithms();
            
            int numberToTest = 118;
            for (int i = 0; i < 2; i++)
            {
                bool isEven = myAlgos.IsEvenNumber(numberToTest);
                if (isEven)
                {
                    Console.WriteLine($"The number {numberToTest} is an even number");
                }
                else
                {
                    Console.WriteLine($"The number {numberToTest} is an not an even but an odd number");
                }
                numberToTest++;
            }
        }
    }
}