namespace WhileTest
{
    internal class WhileTest
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("1 ~ 10의 합계 : {0}", sum);

            // 반복문으로 최초 진입시 조건이 거짓이면 {} 블록을 한번도 실행하지 않는다.
            // while(조건식) {
            //      조건식이 참일 동안 반복할 문장;
            //      ....;
            // }

            sum = 0;
            int j = 1;
            while (j <= 10)
            {
                sum += j;
                j++;
            }
            Console.WriteLine("1 ~ 10의 합계 : {0}", sum);

            sum = 0;
            j = 0;
            while (j <= 10)
            {
                //  j += 2;
                j++;
                // continue : 반복을 건너뛰는 역할을 한다. => 다음 반복으로 넘어간다.
                // => continue문을 만나게 되면 continue 문 밑에 있는 코드는 실행하지 않는다.
                if (j % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("j = " + j);
            }

            // do ~ while : 반복으로 최초진입시 조건이 거짓이더라도 {}블록은 한번은 실행한다.
            // do{
            //      조건이 참일 동안 반복실행할 문장;
            //      ...;
            // }while(조건식); // 마지막에 ';' 잊지말것.

            sum = 0;
            j = 0;

            do
            {
                sum += j++;
            } while (j <= 10);
            Console.WriteLine("1 ~ 10의 합계 : {0}",sum);
        }
    }
}
