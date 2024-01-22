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

            
            int[] answerArr = MakeRandArr();

            //답안 공개
            //Console.WriteLine(String.Join(",",answerArr));

            //답 입력하기
            while (true)
            {
                Console.Write("숫자 3개를 입력(스페이스바로 구분) >> ");
                string str = Console.ReadLine();
                int[] inputArr = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    inputArr[i] = int.Parse(str.Split(" ")[i]);
                }

                //입력받은 답을 기반으로 답안과 비교해보기
                int countStrike = 0;
                int countBall = 0;
                int countOut = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (answerArr[i] == inputArr[j])
                        {
                            if (i == j)
                            {
                                countStrike++;
                            }
                            else
                            {
                                countBall++;
                            }
                        }
                    }

                }
                //스트라이크와 볼을 제외하면 전부 볼이다.
                countOut = 3 - countStrike - countBall;

                //출력
                Console.WriteLine("{0} strike\n{1} ball\n{2} out", countStrike, countBall, countOut);

                //답을 전부 맞춘 경우 게임을 종료
                if (countStrike == 3)
                {
                    Console.WriteLine("전부 맞췄습니다!! 축하합니다~!!!");
                    break;
                }
            }
        }

        //0 ~ 9 사이에서 중복되지 않는 숫자 3개를 뽑아내는 메서드
        static int[] MakeRandArr()
        {
            int[] arr = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }

            for (int i = 1; i < 10000; i++)
            {
                int temp = arr[0];
                int r = random.Next(0, 10);
                arr[0] = arr[r];
                arr[r] = temp;
            }

            int[] arr2 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr[i];
            }
            return arr2;
        }
    }
}
