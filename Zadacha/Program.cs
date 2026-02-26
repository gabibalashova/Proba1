namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter the results of the exams (1-100): ");

            string input = Console.ReadLine();

            int[] results = input.Split(' ').Select(int.Parse).ToArray();
            /*input.Split(' ').Select(x => int.Parse(x.Trim())).ToArray();*/

            int maxResult = results.Max();
            int minResult = results.Min();
            double averageResult = results.Average();
            int aboveAverageCount = 0;

            foreach (int result in results)
            {
                if (result > averageResult)
                {
                    aboveAverageCount++;
                }
            }

            Array.Sort(results);

            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Highest result/s: " + maxResult);
            Console.WriteLine("Lowest result/s: " + minResult);
            Console.WriteLine("Average result/s: " + averageResult);
            Console.WriteLine("Above average result/s: " + maxResult);
            Console.WriteLine("All results" + string.Join(", ", results));

        }
    }
}
