namespace CardShuffleTest
{
    internal class CardShuffleTest
    {
        static void Main(string[] args)
        {
            /*
            // 두 변수에 저장된 값 교환하기
            int a = 3, b = 4;
            Console.WriteLine("a = {0}, b= {1}", a, b);
            //a = b; // a에 b의 값을 대입해서 기존의 a값은 없어지고 b의 값으로 바뀐다.=> a==4
            //b = a; // a == 4 이므로 b에는 4가 대입됨.
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("a = {0}, b= {1}", a, b);
            */

            //cards라는 int형 배열을 만들고 0~51까지 초기화한다.
            int[] cards = new int[52];
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = i;
            }
            Console.WriteLine(string.Join(",", cards));//배열 내부의 내용물을 주욱 나열해줌
            string[] number = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] symbol = { "◆", "♡", "♠", "♧" };
            PrintCards(cards, number, symbol);
            Console.WriteLine("======섞기전======");


            // 섞는다 => 값 교환
            // cards[0]의 값과 card[1]~ card[51] 사이의 랜덤위치의 값을 교환.

            Random random = new Random();

            for (int i = 0; i < 10000; i++)
            {
                int r = random.Next(1, 52);
                int tmp = cards[0];
                cards[0] = cards[r];
                cards[r] = tmp;
            }

            // Console.WriteLine(string.Join(",", cards));
            // 값 교환 후 상태 출력
            PrintCards(cards, number, symbol);
            Console.WriteLine("======섞기후======");
        }

        private static void PrintCards(int[] cards, string[] number, string[] symbol)
        {
            //for (int i = 0; i < cards.Length; i++)
            //{
            //    // Console.Write("{0,-2}", cards[i]);                
            //    Console.Write("{0,2}", symbol[cards[i] / 13]);
            //    Console.Write("{0,-2}", number[cards[i] % 13]);

            //    if ((i + 1) % 13 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            for (int i = 0; i < cards.Length; i++)
            {                          
                Console.Write("{0}{1,-2} ", symbol[cards[i] / 13], number[cards[i] % 13]);
                if ((i + 1) % 13 == 0)
                {
                    Console.WriteLine();
                }
            }



        }
    }
}
