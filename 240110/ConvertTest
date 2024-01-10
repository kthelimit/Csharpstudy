namespace ConvertTest
{
    internal class ConvertTest
    {
        static void Main(string[] args)
        {
            Console.Write("2진수로 변환할 10진수를 입력하세요 > ");
            int dec = Convert.ToInt32(Console.ReadLine());
            int[] bin = new int[8]; // 결과를 기억할 배열을 선언한다.
                                    // 모두 0으로 자동 초기화
            int num = dec;

            int index = 0; // 배열의 인덱스로 사용할 변수

            // 입력되는 10진수의 크기에 따라 반복홋수가 달라지므로 무한루프로 처리.
            while (true)
            {
                int m = dec / 2; // 몫
                int r = dec % 2; // 나머지
                bin[index++] = r;
                
                //dec에 저장된 10진수를 2로 나눈 몫이 0이 되면 무한루프를 탈출한다.
                if (m==0)
                {
                    break;
                }
                //이전 작업의 몫인 m은 다음 작업의 dec가 된다.
                dec = m;
            }

            Console.Write($"{num}을(를) 2진수로 변환하면 =>");

            for(int i = index-1; i>=0; i--)
            {
                Console.Write(bin[i]);
            }
            Console.WriteLine("입니다.");
        }
    }
}
