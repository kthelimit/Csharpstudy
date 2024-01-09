namespace BubbleSortEarlyStop
{
    internal class BubbleSortEarlyStop
    {
        static void Main(string[] args)
        {

            // 버블정렬(bubble sort)
            // => j번째 인덱스의 데이터를 선택해서 j+1번째 인덱스의 데이터와 비교하며
            // 앞의 값이 크면 데이터를 교환한다. - 오름차순

            // int[] data = { 3, 9, 2, 8, 1 };
            int[] data = { 9, 8, 1, 2, 3};
            for (int i = 0; i < data.Length - 1; i++)
            {
                // flag라는 변수를 만들어 true 초기화한다.
                bool flag = true;
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;
                        // 값 교환이 이루어지면 flag변수에 false를 저장
                        flag = false;
                    }

                }// 회전 종료
                // 정렬이 완료된 상태면 더 이상 회전할 필요가 없으므로 i반복을 탈출.
                if (flag)
                {
                    break; // 가장 가까운 반복문을 탈출(강제종료)한다.
                }
                Console.WriteLine(i + 1 + "회전 : " + string.Join(", ", data));
            }// 정렬 종료




        }
    }
}
