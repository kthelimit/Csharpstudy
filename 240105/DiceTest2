namespace DiceTest2
{
    internal class DiceTest2
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] count = new int[6];
            //주사위의 눈의 개수를 기억할 배열. =>0으로 자동초기화
            //count[0] => 1의 개수 ~ count[5] => 6의 개수

            int[] Dice = new int[10];
            for (int i = 0; i < Dice.Length; i++)
            {
                Dice[i] = random.Next(1, 7);
                //switch (Dice[i])
                //{
                //    case 1: count[0]++; break;
                //    case 2: count[1]++; break;
                //    case 3: count[2]++; break;
                //    case 4: count[3]++; break;
                //    case 5: count[4]++; break;
                //    case 6: count[5]++; break;
                //}
                count[Dice[i] - 1]++;
            }

            foreach (int i in Dice)
            {
                Console.Write("{0,2} ", i);
            }
            Console.WriteLine();

            for(int i =0; i < count.Length; i++)
            {
                Console.WriteLine($"{i+1}의 개수 = {count[i]}");
            }
        }
    }
}
