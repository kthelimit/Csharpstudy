namespace SoinsooTest
{
    internal class SoinsooTest
    {
        static void Main(string[] args)
        {
            int n;
            // n이 2이상이면 소인수 분해를 시작하고 그렇지 않으면 반복 종료

            while (true)
            {
                Console.Write("숫자입력 > ");
                n = int.Parse(Console.ReadLine());
                if (n < 2)
                {
                    break;
                }

                // 소인수 분해 => n을 2부터 나누기 시작해서 나머지가 0이 될때까지...
                // 나머지가 0이 되면 나눈 수를 배열에 저장한다.
                //n이 1이 될때까지 소인수 분해를 실행한다. n==1이면 반복종료,


                int[] s = new int[20];
                int num = n;
                int c = 0; // 배열의 인덱스. 소인수의 개수.

                while (true)
                {
                    int k = 2;
                    while (true)
                    {
                        int r = n % k;
                        if (r == 0)
                        {
                            break;
                        }
                        //소인수 분해가 되지않으면 k를 1 증가시키고 다시 소인수 분해.
                        k++;
                    }
                    // 소인수 분해가 되었다면 s배열에 소인수를 넣어준다.
                    s[c++] = k;
                    // 다음 소인수를 얻기 위해서 n을 k로 나눈 몫을 넣어준다.
                    n /= k;
                    if (n == 1) //소인수 분해가 끝났는가
                    {
                        break;
                    }
                }
                // 소인수 출력
                // n이 소수면 소수하고 출력을 하고, 소수가 아니면 소인수를 출력.
                // 소인수의 개수(c)가 1개라면 자기 자신으로 나눠 떨어진 것이므로 소수이다.
                if (c == 1) //n이 소수인가?
                {
                    Console.WriteLine(num + "은 소수입니다.");
                }
                else
                {
                    Console.Write(num + " = ");
                    for (int y = 0; y < c - 1; y++)
                    {
                        Console.Write(s[y] + " * ");
                    }
                    Console.WriteLine(s[c - 1]);
                }
            }
            Console.WriteLine("프로그램을 종료합니다.");
        }
    }
}

