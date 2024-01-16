namespace SelectionSort
{
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            // 선택정렬(selection sort)
            // => i번째 데이터를 선택해서 j번째 데이터와 비교한 후, 앞의 데이터가 크면
            // => 두 기억장소에 저장된 값을 교환한다. = 오름차순

            //  i       j
            //  0       1   2   3   4
            //  1           2   3   4
            //  2               3   4
            //  3                   4

            // for(int i=0;i<4;i++)
            //for(int j=i+1;j<5;j++)

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = i + 1; j < 5; j++)
            //    {

            //        Console.WriteLine("i = " + i + ", j = " + j);

            //    }
            //    Console.WriteLine("===========");
            //}


            int[] data = { 8, 4, 5, 9, 1 };
            Console.WriteLine(string.Join(",", data));
            Console.WriteLine("=====정렬=====");

            for (int i = 0; i < data.Length - 1; i++) // 선택 위치, 회전 수 제어
            {
                for (int j = i + 1; j < data.Length; j++)  //선택 위치의 데이터와 비교할 대상이 되는 데이터 위치.
                {
                    // 오름차순 정렬
                    // 앞(i번째)의 데이터가 뒤(j번째)의 데이터보다 크면 값을 교환
                    // 내림차순 정렬
                    // 앞(i번째)의 데이터가 뒤(j번째)의 데이터보다 작으면 값을 교환
                    // 관계연산자 ">"면 오름차순 정렬 / "<"면 내림차순 정렬

                    if (data[i] > data[j])
                    {
                        int tmp = data[i];
                        data[i] = data[j];
                        data[j] = tmp;
                    }
                } //회전 종료
                Console.WriteLine(i + 1 + "회전 결과 : " + string.Join(", ", data));
            }
            //Console.WriteLine(string.Join(", ", data));

        }
    }
}
