using System.ComponentModel.Design;

namespace Hackathon01_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var max = int.Parse(Console.ReadLine());

            Enumerable.Range(1, max)
                .Select(i => (i % 3 == 0 && i % 5 == 0) ? "Damn" :
                             (i % 3 == 0) ? "Build" :
                             (i % 5 == 0) ? "School" :
                              i.ToString()
                       )
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
