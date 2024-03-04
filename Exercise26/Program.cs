namespace Exercise26
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] anArray = new int[,] { { 1, 5, 7, 4 }, { 1, 3, 12, 2 }, { 23, 25, 12, 13 } };
            foreach (int i in anArray)
            {
                var number = anArray.Select((i) => i).Max();
                Console.WriteLine($"Maximum number = {number}");
            }
            
        }
    }
}