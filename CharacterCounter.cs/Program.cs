namespace CharacterCounter.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
            .ToLower()                              
            .Split(' ') 
            .GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());

            // 輸出結果
            foreach (var item in input)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }


        }
    }
}
