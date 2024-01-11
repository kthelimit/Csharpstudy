namespace SnailTest
{
    internal class SnailTest
    {
        static void Main(string[] args)
        {
            Console.Write("행렬의 차수 입력>> ");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, row];
            int n = 0;  //배열에 채워질 숫자를 1씩 증가시킬 변수
            //행과 열이 1 또는 -1씩 증가 및 감소처리에 사용할 변수
            int s = 1;
            int i = 0;  // 행
            int j = -1; // 열
            int k = a.GetLength(1);  // 반복횟수

            while (true)
            {
                for (int p = 1; p <= k; p++) // 열 채우기
                {
                    j += s;
                    a[i, j] = ++n;
                }                
                if (--k == 0)
                {
                    break;
                }
                for (int p = 1; p <= k; p++) // 행 채우기 //p=0으로 시작해서 오류가 났군...
                {                    
                    i += s;
                    a[i, j] = ++n;
                }
                s *= -1;
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
