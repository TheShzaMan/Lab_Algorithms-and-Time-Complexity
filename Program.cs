namespace Lab_Algorithms_and_BigONotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithms myAlgos = new Algorithms();
            
            //Task 1
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

            //Task 2
            List<int> numbersList = new List<int>() { 9, 4, 90, -8, 66, 99, 1, 43 };
            List<int> numbersList2 = new List<int>() { 9, 4, 90, -8, 425, 99, 43};
            
            bool isLess = myAlgos.IsLessThan100(numbersList);
            if ( isLess )
            {
                Console.WriteLine($"Every number in this list is less than 100");
            }
            else
            {
                Console.WriteLine($"One or more numbers in this list are more than 100");
            }
            isLess = myAlgos.IsLessThan100(numbersList2);
            if (isLess)
            {
                Console.WriteLine($"Every number in this list is less than 100");
            }
            else
            {
                Console.WriteLine($"One or more numbers in this list are more than 100");
            }

            //Task 3
            List<string> namesList = new List<string>() { "Martha", "Danielle", "Steven", "Mark" };
            List<string> namesList2 = new List<string>() { "Martha", "Danielle", "Steven", "Martha", "Mark" };

            bool hasMultiple = myAlgos.HasMultipleNames(namesList);
            if ( hasMultiple )
            {
                Console.WriteLine("This list has multiple names");
            }
            else
            {
                Console.WriteLine("This list does not have multiple names");
            }
            hasMultiple = myAlgos.HasMultipleNames(namesList2);
            if (hasMultiple)
            {
                Console.WriteLine("This list has multiple names");
            }
            else
            {
                Console.WriteLine("This list does not have multiple names");
            }
        }
    }
}