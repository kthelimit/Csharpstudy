namespace FibonacciTest
{
    internal class FibonacciTest
    {
        static void Main(string[] args)
        {
            int a = 1; // n - 2항
            int b = 1; // n - 1항
            int y = 2; // 피보나치 수열의 합계를 구할 변수

            Console.Write("피보나치 수열을 구할 항수 입력>> ");
            int n=Convert.ToInt32(Console.ReadLine());

            // 1항과 2항의 값은 위에서 이미 합계가 계산된 상태이므로 3번째 항부터 
            // n번째 항까지 합계를 누적한다.
            for(int k=3; k<=n; k++)
            {
                int c = a + b; // n항 =>n-2항과 n-1항의 값을 더한 값
                y += c;

                // 피보나치 수열의 다음 항 값을 계산하기 위해 변수값을 수정 => 값을 이동시킨다.
                a = b; // 현재 작업의 n-1항 값을 다음 작업의 n-2항으로 넣어준다.
                b = c; // 현재 작업의 n항의 값을 다음 작업의 n-1항으로 넣어준다.
            }
            Console.WriteLine("피보나치 수열의 {0}번째 항까지의 합계 : {1}",n,y);

        }
    }
}
