namespace SoSooTest
{
    internal class SoSooTest
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 >>");
            int n = Convert.ToInt32(Console.ReadLine());

            // 소수는 1 외에 약수가 자기자신만 있는 수.
            // 3의 약수는 1,3 이므로 소수
            // 4의 약수는 1, 2, 4이므로 소수가 아니다.
            // 모든 수는 1로 나눠 떨어지기 때문에 2부터 나눠떨어질때까지 나눈다.
            int i;
            for (i = 2; i <= n; i++)
            {
                //나눠서 떨어지는 수는 소수인지 아닌지 판단하기 위해서 반복 탈출
                if (n % i == 0)
                {
                    break;
                }
            }
            //if (n == i)
            //{
            //    Console.WriteLine($"{n}은(는) 소수입니다.");
            //}
            //else
            //{
            //    Console.WriteLine($"{n}은(는) 소수가 아닙니다.");
            //}

            //조건 연산자(삼항연산자) => 조건식 ? 참일 때 : 거짓일 때
            Console.WriteLine(n+"은(는) "+(n==i? "소수입니다" : "소수가 아닙니다."));
        }
    }
}
