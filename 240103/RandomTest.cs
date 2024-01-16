namespace RandomTest
{
    internal class RandomTest
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Random이라는 클래스를 random이라는 이름으로 생성한 것임

            // Next() : 임의의 정수(>=0)
            // Next(값1, 값2) : 값1 이상 값2 미만의 랜덤 수(정수)
            // Next(값) : 값보다 작은 임의의 양의 정수(>=0)
            // NextBytes(bytes[] buffer) : byte 타입의 배열에 random한 값을 채워넣는 메소드.
            // NextDouble() : double 타입의 임의의 수를 반환. 0~0.99999 수가 나옴

            int num = random.Next();
            Console.WriteLine(num);

            num = random.Next(1, 10);
            Console.WriteLine(num);

            num = random.Next(45);
            Console.WriteLine(num);

            double num2 = random.NextDouble();
            Console.WriteLine(num2);

            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine("=======================");
            Console.WriteLine(random.Next(45) + 1); //1~45까지 나옴
            Console.WriteLine(random.Next(45) + 1);
            Console.WriteLine(random.Next(45) + 1);
            Console.WriteLine(random.Next(45) + 1);
            Console.WriteLine(random.Next(45) + 1);
            Console.WriteLine(random.Next(45) + 1);
            Console.WriteLine("=======================");
            Console.WriteLine((int)(random.NextDouble() * 45 + 1));
            Console.WriteLine((int)(random.NextDouble() * 45 + 1));
            Console.WriteLine((int)(random.NextDouble() * 45 + 1));
            Console.WriteLine((int)(random.NextDouble() * 45 + 1));
            Console.WriteLine((int)(random.NextDouble() * 45 + 1));
            Console.WriteLine((int)(random.NextDouble() * 45 + 1));


        }
    }
}
