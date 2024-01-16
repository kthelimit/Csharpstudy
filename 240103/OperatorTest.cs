namespace OperatorTest
{
    internal class OperatorTest
    {
        static void Main(string[] args)
        {
            // 산술 연산자 : +, -, *, /, % => 나머지
            Console.WriteLine(5.3 % 2.1);

            // 증감 연산자 : ++(1증가), --(1감소)
            // a++(후위 연산) : 연산 후 1 증가 => a의 값을 다른 연산에 먼저 사용하고 값을 1 증가 시킴
            // ++a(전위 연산) : 1 증가 후 연산 => a의 값을 1 증가하고 연산에 사용.
            // a--(후위 연산) : 연산 후 1 감소 => a의 값을 다른 연산에 먼저 사용하고 값을 1 감소 시킴
            // --a(전위 연산) : 1 감소 후 연산 => a의 값을 1 감소하고 연산에 사용.

            int a = 1, b, c;
            a++; // a= a+1;
            Console.WriteLine("a = " + a);
            ++a;
            Console.WriteLine("a = " + a);
            b = a++;
            Console.WriteLine("a = " + a + ", b = " + b);
            c = ++a;
            Console.WriteLine("a = " + a + ", c = " + c);

            Console.WriteLine(--a); //4
            Console.WriteLine(a);   //4
            Console.WriteLine(a--); //4
            Console.WriteLine(a);   //3


            int d = 1;
            int e = ++d + ++d + ++d + ++d; // 2+3+4+5=14 그러나 사실 뒤에서부터 계산된다고 함... ++은 뒤에서부터..?
            Console.WriteLine($"d = {d}, e = {e}");

            // 관계연산자(비교연산자) : 연산의 결과는 참(true), 또는 거짓(false)이다.
            // => > : 초과, < : 미만, >= : 이상, <= : 이하, != : 같지않다., == : 같다.
            // 얘네를 쓰는 걸 조건식이라고 부름.
            Console.WriteLine(3>4);
            Console.WriteLine(1 <= 2);

            char c1 = 'A';
            char c2 = 'a';
            Console.WriteLine(c1 == c2);

            // 논리연산자 : 연산의 결과는 참(true) 또는 거짓(false)이다.
            // && : and(논리곱) => 조건1 && 조건2 => 두 조건이 모두 참(true)일 경우에만 참.
            // => ~이고 / ~이면서 / ~그리고
            // || : or(논리합) => 조건1 || 조건2 => 두 조건 중에서 하나 이상 참(true)일 경우에만 참.
            // => ~이거나 / ~또는 / ~혹은
            // ! : not(논리부정) => !조건 => 참을 거짓으로, 거짓을 참으로 바꿈.
            Console.WriteLine(3 == 4 && 4 < 5);
            Console.WriteLine(3 <= 4 && 4 == 4);
            Console.WriteLine(3 == 4 || 4 < 5);
            Console.WriteLine(3 <= 4 || 4 == 4);
            Console.WriteLine(!(3<=4));
            Console.WriteLine(!false);

            // 대입(할당)연산자
            // = : 오른쪽에 있는 값을 왼쪽 변수에 대입(할당)한다.
            // => +=, -=, *=, /=, %=  => a = a + 1 : a += 1 / a *= 1 => a = a * 1
            int num = 1;
            num += 3; // num = num + 3;
            Console.WriteLine(num);
            Console.WriteLine(num*=10);
            num /= 10; // num = num /10;
            Console.WriteLine(num);


            // 연산자 우선순위
            // => () => 단항 연산자(후위연산자 => 전위연산자, +, -) => 산술연산자(*, /, %)
            // => 산술연산자(+,-) => 연결연산자(+)(이 +들은 거의 비슷하다)=>관계연산자(>, >=, <, <=, == , !=)
            // => 논리연산자(&& =>||) => 삼항연산자(조건 연산자)(? :) => 대입연산자
            //연산자 진행방향 조건연산자와 대입 연산자를 제외하고는 왼쪽에서 오른족으로 진행.

            //단항연산자 : 연산자가 하나임

            


        }


    }
}
