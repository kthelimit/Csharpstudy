namespace EuclidTest
{
    internal class EuclidTest
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 숫자를 입력하세요 >");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력하세요 >");
            int b = int.Parse(Console.ReadLine());

            int big, small; 

            // 입력받은 숫자 2개를 큰 수, 작은 수로 판단한다.

            // 큰 수를 작은 수로 나누고 나머지를 계산하고 나머지가 0이면 반복문을 빠져나간다.
            // 나머지가 0이 아니면 큰 수 = 작은 수 / 작은 수 = 나머지
            // 최대공약수와 최소공배수를 출력한다.

            if (a > b)
            {
                big = a;
                small = b;
            }
            else
            {
                big = b;
                small = a;
            }

            while (big % small != 0)
            {
                int r = big % small;
                big = small;
                small = r;
            }
            Console.WriteLine($"{a}과 {b}의 최대 공약수는 {small}이고 최소공배수는 {a*b/small}이다.");
        }

    }
}

