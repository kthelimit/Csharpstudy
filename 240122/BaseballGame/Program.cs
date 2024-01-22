namespace BaseballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 ~ 9 까지 무작위 3자리 수.
            // 같은 자리 같은 수 = strike
            // 다른 자리 포함된 수(같은 수) = ball
            // 3자리 숫자와 다른 수 => out
            int gamelevel = 5;

            int[] gameArr = BaseballGame.MakeGameArr(gamelevel);
            int[] player;
            int sCount = 0;
            int bCount = 0;
            int count = 0;


            Console.WriteLine(string.Join(" ", gameArr));

            while (true)
            {
                //3자리 숫자 입력하기
                player = BaseballGame.InputPlayerArr(gamelevel);

                //sCount 계산
                sCount = BaseballGame.CheckSCount(gameArr, player);

                //bCount 계산
                bCount = BaseballGame.CheckBCount(gameArr, player);

                Console.WriteLine($"{++count}회차: {sCount}Strike, {bCount}Ball, {gamelevel - sCount - bCount}Out");
                if (sCount == gamelevel)
                {
                    Console.WriteLine("승리하셨습니다!!");
                    Console.WriteLine("게임 숫자 : {0}", string.Join(" ", gameArr));
                    break;
                }
                if (count == 5)
                {
                    Console.WriteLine("5회차 내에 끝내지 못하셨습니다.");
                    break;
                }

            }
        }


    }
}
