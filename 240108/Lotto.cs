namespace Lotto
{
    internal class Lotto
    {
        static void Main(string[] args)
        {
            // 1 ~ 45까지 숫자를 기억할 배열
            // 배열의 값을 섞는다.
            // 로또 번호 출력한다. 6개의 중복되지않은 숫자를 나타낸다.

            int[] lotto = new int[45];
            //lotto 배열을 1~45까지 초기화
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = i + 1;
            }
            //  Console.WriteLine(string.Join(",",lotto));
            for(int i=0;i<lotto.Length;i++)
            {
                Console.Write($"{lotto[i],-2:00} ");
                if((i+1)%9==0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("==========================");


            // 배열의 값을 섞는다
            Random random = new Random();
            for (int i = 0; i < 100000; i++)
            {
                int r = random.Next(1, 45);
                int tmp = lotto[0];
                lotto[0] = lotto[r];
                lotto[r] = tmp;
            }
            // Console.WriteLine(string.Join(",", lotto));

            for (int i = 0; i < lotto.Length; i++)
            {
                Console.Write($"{lotto[i],-2:00} ");
                if ((i + 1) % 9 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("==========================");



            Console.Write("로또 번호 : ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{lotto[i],2:00} ");
            }
            Console.WriteLine();
            Console.WriteLine("보너스 번호 : " + lotto[6]);
        }
    }
}
