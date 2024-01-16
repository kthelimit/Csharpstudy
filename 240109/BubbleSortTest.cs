namespace BubbleSortTest
{
    internal class BubbleSortTest
    {
        static void Main(string[] args)
        {
            // 버블정렬(bubble sort)
            // => j번째 인덱스의 데이터를 선택해서 j+1번째 인덱스의 데이터와 비교하며
            // 앞의 값이 크면 데이터를 교환한다. - 오름차순

            // int[] data = { 3, 9, 2, 8, 1 };
            int[] data = { 9, 1, 3, 2, 8 };
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;                   
                    }
 
                }// 회전 종료
                Console.WriteLine(i + 1 + "회전 : " + string.Join(", ", data));
            }// 정렬 종료



        }
    }
}
