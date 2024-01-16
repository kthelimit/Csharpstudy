namespace DiceTest3
{
    internal class DiceTest3
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] count = new int[6];
            for (int i = 0; i < 10; i++)
            {
                count[random.Next(6)]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine($"{i + 1}의 개수 = {count[i]}");
            }
        }
    }
}
