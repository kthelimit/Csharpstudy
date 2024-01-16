namespace MenuTest
{
    internal class MenuTest
    {
        static void Main(string[] args)
        {
            int menu = 0; // 메뉴에 있는 번호를 저장할 변수 선언
            while (menu != 4)
            {
                do
                {

                    Console.WriteLine("===================================");
                    Console.WriteLine("1.입금 | 2.출금 | 3.잔액 | 4.종료");
                    Console.WriteLine("===================================");
                    Console.Write("원하는 메뉴를 선택하세요. > ");
                    menu = Convert.ToInt32(Console.ReadLine());

                } while (menu < 1 || menu > 4);
                switch (menu)
                {
                    case 1: Console.WriteLine("입금"); break;
                    case 2: Console.WriteLine("출금"); break;
                    case 3: Console.WriteLine("잔액"); break;
                }
            }
            Console.WriteLine("프로그램을 종료합니다.");

        }
    }
}
