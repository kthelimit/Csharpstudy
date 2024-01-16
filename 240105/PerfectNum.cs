namespace PerfectNum
{
    internal class PerfectNum
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 >> ");
            int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.WriteLine("{0,3}은(는) {1}의 약수입니다.", i, num);
            //    }
            //} //약수 구하기(자기자신 포함)

            // 모든 숫자는 자기 자신을 제외하고 나눠서 떨어뜨릴 수 있는 가장 큰 수는 자신의 절반을 넘지않는다.


            int sum = 0; // 자기 자신을 제외한 약수의 합계를 구함
            for (int i = 1; i <= num / 2; i++)
            {
                //입력한 숫자의 약수인지 아닌지 판단
                if (num % i == 0)
                {
                    Console.WriteLine("{0,3}은(는) {1}의 약수입니다.", i, num);
                    sum += i; // 약수의 합계를 구한다.
                }
            }
            // 완전수인지 아닌지 판단
            if (sum == num)
            {
                Console.WriteLine("{0,3}은(는) 완전수입니다.", num);
            }
            else
            {
                Console.WriteLine("{0,3}은(는) 완전수가 아닙니다.", num);
            }
        }
    }
}
