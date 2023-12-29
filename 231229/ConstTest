using System;

namespace ConstTest
{
    internal class Program
    {
        //열거형 Season 정의
        enum Season
        {
            spring, // 0
            summer, // 1
            autumn, // 2
            winter  // 3
        }

        enum Fruits
        {
            apple = 10,
            orange = 100,
            tomato = 20
        }
        static void Main(string[] args)
        {
            // 상수 : 변하지 않는 값
            // const 자료형 상수명 = 값;
            const int a = 3;
            // const int b;
            // b = 4;
            // 에러 : 상수는 선언과 동시에 초기화가 되어야함

            // a = 5; // 에러 : 상수는 값을 변경시킬 수 없다.

            const double d = 3.14;
            const string s = "abcdef";
            Console.WriteLine("a = " + a + ", d = " + d + ", s = " + s);

            // 열거 형식 : 상수들의 집합
            // => 기본적으로 연결된 상수값은 int형이다.
            // => 0으로 시작하고 텍스트 순서에 따라 1씩 증가
            // => class 내부 또는 namespace 내부에서 선언해야한다.
            // => 새로운 타입(자료형)을 정의하는 것과 같음
            // enum 열거형식명 {상수1, 상수2, ....}
            // 연결된 상수값을 명시적으로 지정도 가능함

            //열거형식 변수정의 => 열거형식명 변수명;

            Season season;
            season = Season.spring;
            Console.WriteLine(season); //열거형 멤버이름으로 출력

            season = Season.winter;
            Console.WriteLine(season);
            Console.WriteLine(Season.summer);

            Fruits fruits;
            fruits = Fruits.apple;
            Console.WriteLine(fruits);


            // var 키워드 : 뱐수 선언시 형식을 직접 선언한 것처럼 컴파일러가 형식을 결정
            // => var 변수명 = 값;
            // => var 키워드는 선언과 동시에 초기화 해야한다.

            int num = 20;
            var num1 = 10;
            Console.WriteLine(num1);

            string str = "둘리";
            var str1 = "고길동";
            Console.WriteLine(str1);


        }
    }
}
