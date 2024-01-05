namespace PerfectNum2
{
    internal class PerfectNum2
    {
        static void Main(string[] args)
        {
            int lm = 0;

            for (int n = 4; n <= 10000; n++)
            {
                int sum = 0;
                int k = n / 2;
                for (int j = 1; j <= k; j++)
                {
                    // 완전수인가 판단할 수(n)의 약수를 판단하기 위해 j로 n을 나눈 나머지를 계산한다.
                    int r = n % j;
                    if (r == 0) // j가 n의 약수인가?
                    {
                        // j가 n의 약수이면 n의 약수의 합계를 계산한다.
                        sum += j;
                    }
                }// 내부 for 끝
                // 완전수인지 판단.
                if (sum == n)
                {
                    lm++;
                    Console.WriteLine($"{lm}번째 완전수 => {n, -4}");
                }
            }//외부 for 끝
            
            // 전체 완전수의 개수
            Console.WriteLine("4 ~ 10000 사이의 완전수는 {0}개입니다.", lm);


        }
    }
}
