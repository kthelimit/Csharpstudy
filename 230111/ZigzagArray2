namespace ZigzagArray2
{
    internal class ZigzagArray2
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            int k = 0;
            // 2차원 배열에서 숫자가 채워지기 시작하는 열 인덱스
            int l = 0;
            //2차원 배열에서 숫자가 채워지기 시작하는 마지막 열 인덱스
            int h = a.GetLength(1) - 1;
            // l부터 h까지 증가치로 사용할 변수
            int s = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = l; j != h + s; j += s)
                {
                    a[i, j] = ++k;
                }
                int temp = l;
                l = h;
                h = temp;
                s *= -1;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{a[i, j],3:00}");
                }
                Console.WriteLine();
            }
        }
    }
}
