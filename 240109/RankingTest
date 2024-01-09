namespace RankingTest
{
    internal class RankingTest
    {
        static void Main(string[] args)
        {
            int[] score = new int[] { 80, 100, 70, 100, 90 };
            // 순위를 기억하는 배열요소들은 1로 초기화한다.
            int[] rank = new int[score.Length];
            for (int i = 0; i < rank.Length; i++)
            {
                rank[i] = 1;
            }
            //        Console.WriteLine(string.Join(", ", rank));

            for (int i = 0; i < score.Length; i++)
            {
                for (int j = 0; j < rank.Length; j++)
                {
                    if (score[i] < score[j])
                    {
                        rank[i]++;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", rank));

            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine($"{score[i],3}점은 {rank[i]}등 입니다.");
            }
        }
    }
}
