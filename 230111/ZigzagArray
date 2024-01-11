namespace ZigzagArray
{
    internal class ZigzagArray
    {
        static void Main(string[] args)
        {
            // 2차원 배열 : 테이블 형태의 데이터를 저장하는데 사용된다.
            // 타입[ , ] 배열명 = new 자료형[행의 개수,열의 개수]
            // 행인덱스 : 0 ~ 행의 길이 -1 / 열인덱스 : 0 ~ 열의 길이 -1
            // 2차원 배열 요소 접근 => 배열명[행인덱스,열인덱스]
            //int[,] array = new int[3, 4];
            //Console.WriteLine(array[0,0]);

            //int n = 1;
            ////for문 반복시 행을 먼저 적는듯.
            //for(int i=0; i<3;i++)
            //{
            //    for(int j=0; j<4;j++)
            //    {
            //        array[i, j] = n++;
            //    }
            //}
            //array[1, 1] = 30;
            ////Console.WriteLine(string.Join(", ", array)); 

            //for(int i=0; i<3;i++)
            //{
            //    for(int j=0; j<4;j++)
            //    {
            //        Console.Write($"{array[i,j],3}");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write($"{array[i, j],2}");
            //    }
            //    Console.WriteLine();
            //}

            //// 배열명.GetLength(0) : 행의 길이
            //// 배열명.GetLength(1) : 열의 길이
            //// Length : 배열 요소의 총 개수.
            //Console.WriteLine("행의 길이 : " + array.GetLength(0));
            //Console.WriteLine("열의 길이 : " + array.GetLength(1));
            //Console.WriteLine("배열 요소의 개수 : " + array.Length);

            int[,] a = new int[5, 5];
            Console.WriteLine("행의 길이 : " + a.GetLength(0));
            Console.WriteLine("열의 길이 : " + a.GetLength(1));

            int n = 0; //배열에 채워질 숫자를 1씩 증가시키는 변수

            for (int i = 0; i < a.GetLength(0); i++)
            {
                //for (int j = 0; j < a.GetLength(1); j++)
                //{
                //    if (i % 2 == 0)
                //    {
                //        a[i, j] = i * a.GetLength(1) + n++;
                //    }
                //    else
                //    {
                //        a[i, j] = i * a.GetLength(1) - 1 + n--;
                //    }
                //} //아래쪽이 더 이해하기 쉽다.

                //짝수 행과 홀수 행이 숫자가 채워지는 방법이 다르므로 반복문을 별도로 만든다.
                if (i % 2 == 0)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = ++n;
                    }
                }
                else
                {
                    for (int j = a.GetLength(1) - 1; j >= 0; j--)
                    {
                        a[i, j] = ++n;
                    }
                }
            }

            for (int i = 0; i < a.GetLength(0); i++) //행
            {
                for (int j = 0; j < a.GetLength(1); j++) //열
                {
                    Console.Write($"{a[i, j],3:00}");
                }
                Console.WriteLine();
            }


        }
    }
}
