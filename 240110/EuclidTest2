namespace EuclidTest2
{
    internal class EuclidTest2
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 수 입력 > ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두번째 수 입력 > ");
            int b = int.Parse(Console.ReadLine());
            int r = 1;

            int high, low;
            if (a > b)
            {
                high = a;
                low = b;
            }
            else
            {
                low = a;
                high = b;
            }

            int l;
            while (r > 0)
            {
                r = high % low;
                high = low;
                low = r;
            }

            l = a * b / high;
            Console.WriteLine("최대공약수 : {0}, 최소공배수 : {1}", high, l);

        }
    }
}
