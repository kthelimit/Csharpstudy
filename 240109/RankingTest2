namespace RankingTest2
{
    internal class RankingTest2
    {
        static void Main(string[] args)
        {
            int[] score = new int[] { 80, 100, 78, 94, 90 };
            int[] rank = new int[score.Length];
            for (int i = 0; i < rank.Length; i++)
            {
                rank[i] = 1;
            }
            for (int i = 0; i < score.Length - 1; i++)
            {
                for (int j = i + 1; j < rank.Length; j++)
                {
                    if (score[i] < score[j])
                    {
                        rank[i]++;
                    }
                    else if (score[i] > score[j])
                    {
                        rank[j]++;
                    }
                } // for j 끝
            } // for i 끝

            Console.WriteLine(string.Join(", ", rank));

            for (int i = 0; i < score.Length; i++)
            {
                Console.Write($"{score[i],3}점은 {rank[i]}등 입니다.");

                // 10점당 ☆ 하나씩, 5점이상이면 ★하나
                for (int j = 0; j < score[i] / 10; j++)
                {
                    Console.Write("☆");
                }
                if (score[i] % 10 >= 5)
                {
                    Console.Write("★");
                }
                Console.WriteLine();
            }
        }
    }
}
