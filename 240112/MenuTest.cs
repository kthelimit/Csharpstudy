namespace MenuTest
{
    internal class MenuTest
    {

        // 메서드 : 특정 작업을 수행하기 위한 일련의 명령문이 포함되어있다.
        // => 클래스 내부에 선언 및 정의해야한다.
        // [접근제한자][static] 반환타입 메서드이름([매개변수1,....])
        // {
        //          메서드가 실행할 문장;
        //          ...;
        //          [return 값;]
        // }
        // 접근제한자 : puplic / private / protected / internal
        // public : 어디에서나 접근 가능
        // private : 같은 클래스 내부에서만 접근 가능
        // => 메서드나 필드의 경우, 접근제한자를 지정하지 않으면 기본적으로 private으로 지정된다.
        // protected : 상속받은 자식 클래스(파생 클래스)에서만 접근 가능.
        // internal : 같은 프로젝트(어셈블)에서는 public, 그렇지않으면 private.
        // => 클래스의 접근제한자를 지정하지 않으면 internal이 기본적으로 지정된다.

        // 반환타입(리턴타입) : 메서드가 실행되고 난 후, 결과를 되돌려 줄 때 결과의 데이터 타입
        // => return 값과 일치하는 데이터 타입이어야한다.
        // => 반환값(리턴값)이 없다면 반환 타입은 void이다.
        // => return 값은 메서드가 실행되고 난 후 반환할 결과 값.

        // 매개변수 : 메서드를 호출할 때 전달되는 값.
        // => 메서드 실행 시 사용된다.

        // 메서드 정의하기
        // => 어떤 기능을 실행할 지 생각
        // => 메서드 이름은 동사로 시작하고 첫문자는 대문자로 하는게 좋다(관례적)

        // 메서드 호출하기 =>메서드명([매개변수,..]);
        static void Main(string[] args)
        {
            // static 키워드 : 특정 인스턴스가 아니라 클래스 자체에 소속되도록 지정하는 한정자이다.
            // static은 필드(멤버변수) / 메서드 / 클래스에 사용가능하다.
            // 사용할 때 객체(인스턴스)를 이용하는 것이 아니라 클래스명을 이용해서 사용할 수 있다.
            // => 클래스명.필드명 / 클래스명.메서드명
            // 정적(static)멤버는 인스턴스의 수와 상관없이 항상 한개만 있다.
            // 프로그램 전체에 공유되어야하는 변수 같은 경우 static을 사용할 수 있다.

            //static 메서드 내부에서 인스턴스 멤버는 참조가 안된다.
            // => 인스턴스 객체로부터 호출될 수 없다.
            // static 메서드 또는 static 변수만 참조할 수 있다.

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

                        balance += Deposit();

                        break;
                    case 2:
                        Console.Write("출금할 금액을 입력하세요. > ");
                        money = Convert.ToInt32(Console.ReadLine());

                        balance = WithdrawMoney(balance, money);

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

        static int WithdrawMoney(int balance, int money)
        {
            if (money > balance)
            {
                Console.WriteLine("잔액이 부족합니다.");
            }
            else
            {
                balance -= money;
                Console.WriteLine("{0}원을 출금하셨습니다.", money);
            }
            return balance;
        }

        static int Deposit()
        {
            Console.Write("입금할 금액을 입력하세요. > ");
            int money = Convert.ToInt32(Console.ReadLine());
           
            //balance += Convert.ToInt32(Console.ReadLine()); //한줄로 입력할 수 있다.
            Console.WriteLine("{0}원을 입금했습니다.", money);

            return money;
        }

    }
}
