namespace EuclidTest3
{
    internal class EuclidTest3
    {
        static void Main(string[] args)
        {


            // 두개의 숫자를 한꺼번에 입력받기
            // 입력받은 값을 split() 메서드를 이용해서 배열로 분리하기
            // 분리된 배열의 값을 숫자로 변환해서 => 변수에 저장하기

            Console.Write("2개의 숫자를 입력하세요 > ");
            
            string[] str = Console.ReadLine().Split();
      //      Console.WriteLine(string.Join(", ",str));

            int[] num = new int[str.Length];
            for(int i=0; i<str.Length; i++)
            {
                num[i] = int.Parse(str[i]);
            }


            int big, small;

            // 입력받은 숫자 2개를 큰 수, 작은 수로 판단한다.

            // 큰 수를 작은 수로 나누고 나머지를 계산하고 나머지가 0이면 반복문을 빠져나간다.
            // 나머지가 0이 아니면 큰 수 = 작은 수 / 작은 수 = 나머지
            // 최대공약수와 최소공배수를 출력한다.

            if (num[0] > num[1])
            {
                big = num[0];
                small = num[1];
            }
            else
            {
                big = num[1];
                small = num[0];
            }

            while (true)
            {
                int r = big % small;
                if(r==0)
                {
                    break;
                }
                big = small;
                small = r;
            }
            Console.WriteLine($"{num[0]}과 {num[1]}의 최대 공약수는 {small}이고 최소공배수는 {num[0] * num[1] / small}이다.");
        }
    }
}
