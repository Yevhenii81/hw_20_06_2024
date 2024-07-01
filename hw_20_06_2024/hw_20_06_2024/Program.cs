namespace hw_20_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Alex";
            Console.WriteLine(text1);
            char[] charArray1 = text1.ToCharArray();
            HashSet<string> charSet1 = new HashSet<string>();

            for (int i = 0; i < charArray1.Length; i++)
            {
                Random.Shared.Shuffle(charArray1);
                charSet1.Add(new string(charArray1));
            }

            foreach (var c in charSet1)
            {
                Console.WriteLine(c);
            }
        }
    }
}
