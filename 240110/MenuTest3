namespace MenuTest3
{
    internal class MenuTest3
    {
        static void Main(string[] args)
        {
            int menu = 0; // 메뉴에 있는 번호를 저장할 변수 선언
            // 메뉴 선택시(1~3) 해당 기능 실행할 때 필요한 금액과 잔액 변수 선언.
            int money = 0;
            int balance = 0;


            while (true) // 무한 루프 => 무한루프를 탈출할 수 있는 조건과 break를 이용해서 탈출 할 수 있어야한다. 
            {
                do
                {

                    Console.WriteLine("===================================");
                    Console.WriteLine("1.입금 | 2.출금 | 3.잔액 | 4.종료");
                    Console.WriteLine("===================================");
                    Console.Write("원하는 메뉴를 선택하세요. > ");
                    menu = Convert.ToInt32(Console.ReadLine());

                } while (menu < 1 || menu > 4); // 1~4 외에 숫자가 입력이 되면 메뉴를 계속 보여준다.

                switch (menu)
                {
                    case 1:
                        Console.Write("입금할 금액을 입력하세요. > ");
                        money = Convert.ToInt32(Console.ReadLine());
                        balance += money;
                        //balance += Convert.ToInt32(Console.ReadLine()); //한줄로 입력할 수 있다.
                        Console.WriteLine("{0}원을 입금했습니다. 현재 잔액은 {1}원입니다.", money, balance);
                        break;
                    case 2:
                        Console.Write("출금할 금액을 입력하세요. > ");
                        money = Convert.ToInt32(Console.ReadLine());
                        if (money > balance)
                        {
                            Console.WriteLine("잔액이 부족합니다.");
                        }
                        else
                        {
                            balance -= money;
                            Console.WriteLine("{0}원을 출금하셨습니다. 현재 잔액은 {1}원입니다.", money, balance);
                        }
                        break;
                    case 3:
                        Console.WriteLine("현재 잔액은 {0:c}원 입니다.", balance);
                        break;
                }
                if (menu == 4)
                {
                    break;
                }

            }
            Console.WriteLine("프로그램을 종료합니다.");

        }
    }
}
