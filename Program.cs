namespace calculate_the_vowels_from_the_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter any string");
            var str = Console.ReadLine();

            int VowelsCounter = 0;
            foreach (var item in str)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                    item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
                {
                    VowelsCounter++;
                }

            }
            Console.WriteLine("Number of Vowels = " + VowelsCounter);
        }
    }
}