namespace SnailTest2
{
    internal class SnailTest2
    {
        static void Main(string[] args)
        {
            Console.Write("행렬의 차수 입력>> ");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, row];
            int n = 1;  //배열에 채워질 숫자를 1씩 증가시킬 변수
            //행과 열이 1 또는 -1씩 증가 및 감소처리에 사용할 변수
            int s = 1;
            int i = row / 2;  // 행
            int j = row / 2; // 열
            int k = 0;  // 반복횟수
            a[i, j] = 1;
            bool flag = false; //변화시 브레이크

            while (true)
            {
                k++; //3시 방향
                for (int p = 1; p <= k; p++)  // 열 반복 k가 0이라서 9시방향으로 채워지나봄
                {
                    j += s;
                    n++;
                    if (n > row * row)
                    {
                        flag = true;
                        break;
                    }
                    a[i, j] = n;
                }

                if (flag)
                {
                    break;
                }

                for (int p = 1; p <= k; p++)
                {
                    i += s;
                    a[i, j] = ++n;
                }
                s *= -1;

               // k++; //9시 방향으로 채워짐

            }

            //출력
            for (i = 0; i < a.GetLength(0); i++) //행
            {
                for (j = 0; j < a.GetLength(1); j++) //열
                {
                    Console.Write($"{a[i, j],-4:00}");
                }
                Console.WriteLine();
            }

        }
    }
}
