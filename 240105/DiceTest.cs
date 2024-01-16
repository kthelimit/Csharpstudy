namespace DiceTest
{
    internal class DiceTest
    {
        static void Main(string[] args)
        {

            // 주사위를 10번 굴려서 나오는 눈의 개수를 센다. => 1 ~ 6 사이의 무작위 수
            Random random = new Random();
            //주사위 눈의 개수를 기억할 변수를 선언한다.
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;

            int[] Dice = new int[10];
            for (int i = 0; i < Dice.Length; i++)
            {
                Dice[i] = random.Next(1, 7);
                switch (Dice[i])
                {
                    case 1: num1++; break;
                    case 2: num2++; break;
                    case 3: num3++; break;
                    case 4: num4++; break;
                    case 5: num5++; break;
                    case 6: num6++; break;
                }
            }

            foreach (int i in Dice)
            {
                Console.Write("{0,2}",i);
            }
            Console.WriteLine();
            Console.WriteLine("1이 나온 횟수 : " + num1);
            Console.WriteLine("2가 나온 횟수 : " + num2);
            Console.WriteLine("3이 나온 횟수 : " + num3);
            Console.WriteLine("4가 나온 횟수 : " + num4);
            Console.WriteLine("5가 나온 횟수 : " + num5);
            Console.WriteLine("6이 나온 횟수 : " + num6);
        }
    }
}
