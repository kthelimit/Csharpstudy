namespace Lotto2
{
    internal class Lotto2
    {
        static void Main(string[] args)
        {
            // 금액을 입력 받아서 금액만큼 로또번호를 나타내기

            int[] lotto = new int[45];
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = i + 1;
            }

            // 구매 금액을 입력받는다. => 로또 1회당 1000원 ex) 10000=>10회 반복
            // 구매 금액 만큼 로또 번호 추첨기를 반복 실행한다.
            // 1~45까지 번호 섞기
            // 로또 번호 출력

            Console.Write("금액입력 >> ");
            int money = int.Parse(Console.ReadLine());
            Random random = new Random();
            

            //구매 금액만큼 로또 번호 추첨기를 반복실행한다.
            for (int i = 0; i < money / 1000; i++)
            {
                // 배열의 값을 섞는다
                for (int j = 0; j < 100000; j++)
                {
                    int r = random.Next(1, 45);
                    int tmp = lotto[0];
                    lotto[0] = lotto[r];
                    lotto[r] = tmp;
                }

                //오름차순하기
                int[] lottoNum = new int[6];
                for(int j=0; j<6;j++)
                {
                    lottoNum[j] = lotto[j];
                }
                Array.Sort(lottoNum);
                
                
                // 출력
                Console.Write($"{(char)(65 + i)} 자  동 ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{lottoNum[j],-2:00} ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("금액               {0:c}",money);

        }
    }
}
