namespace FibonacciTest2
{
    internal class FibonacciTest2
    {
        static void Main(string[] args)
        {
            Console.Write("피보나치 수열을 구할 항수 입력>> ");
            int n = Convert.ToInt32(Console.ReadLine());

            // 입력받은 피보나치 수열의 합계를 계산할 항의 개수만큼 배열을 만든다.
            // 배열의 1번째, 2번째 요소를 각각 1로 초기화 시킨다.
            // 피보나치 수열의 각 항 값으로 배열을 채우고 피보나치 수열의 합계를 계산한다.
            // 피보나치 수열을 출력 => 12 = 1+1+2+3+5
            int sum = 2;
            int[] fibo = new int[n];
            Console.WriteLine("배열의 길이 : " + fibo.Length);

            fibo[0] = 1;
            fibo[1] = 1;

            for (int k = 3; k <= fibo.Length; k++)
            {
                fibo[k-1] = fibo[k - 3] + fibo[k - 2];
                sum += fibo[k-1];
            }

            Console.Write("피보나치 수열의 {0}번째 항까지의 합계 {1} = ", n, sum);
            for (int i = 0; i < fibo.Length; i++)
            {
                if(i>0)
                {
                    Console.Write(" + ");
                }
                Console.Write(fibo[i]);


                //Console.Write(fibo[i]);
                //if (i != n - 1)
                //{
                //    Console.Write(" + ");
                //}
            }
            Console.WriteLine();
            //for (int i = 0; i < fibo.Length - 1; i++)
            //{
            //    Console.Write(fibo[i] + " + ");
            //}
            //Console.WriteLine(fibo[fibo.Length - 1]);
        }
    }
}
