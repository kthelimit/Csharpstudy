using System;

namespace DataTypeTest
{
    internal class DataTypeTest
    {
        static void Main(string[] args)
        {
            // 자료형(데이터 타입)
            // 정수형 : int / sbyte / short / long =>signed(부호 있는 데이터 타입)
            // => sbyte(1바이트) : -128 ~ 127 사이의 정수
            // => short(2바이트) : -32,768 ~ 32,767 사이의 정수
            // => int(4바이트) : -2,147,483,648 ~ 2,147,483,647 사이의 정수
            // => long(8바이트) : -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807 사이의 정수
            // unsigned(부호 없는) => byte / ushort / uint / ulong
            // => byte(1바이트) : 0 ~ 255 사이의 음이 아닌 정수
            // 범위를 넘어가면 오버플로우가 되서 0이 되거나 예상치못한 값이 되어버린다

            sbyte a = -10;
            byte b = 40;
            Console.WriteLine("a = " + a + ", b = " + b);

            short c = -30000;
            ushort d = 60000;
            // c = 60000; // 에러 short의 데이터 크기를 벗어남.
            Console.WriteLine("c = " + c + ", d = " + d);

            int e = -10000000; // 0이 7개
            uint f = 3000000000; //0이 8개
            Console.WriteLine("e = " + e + ", f = " + f);
            // e= 2147483648; // 에러 int의 데이터 크기 벗어남.

            long g = -500000000000; //0이 11개
            ulong h = 2000000000000000000; //0이 18개
            Console.WriteLine("g = " + g + ", h = " + h);


            // 부동소수점 : 소수점이 고정되어 있지 않고 움직이면서 수를 표현한다.
            // 실수형 : float / double / decimal
            // float(4바이트) : 단일 정밀도 부동 소수점 형식
            // => 유효자릿수 6 ~ 9
            // double(8바이트) : 복수 정밀도 부동 소수점 형식
            // => 유효자릿수 15~17
            // decimal : 29자리 데이터를 표현할 수 있는 소수 형식
            // => 통화량 등 금융 관련 데이터 저장에 유용

            float x = 3.14f; 
            // float 타입으로 데이터를 저장할 때는 숫자 뒤에 f리터럴을 붙여준다. 대소문자 상관없음
            // 리터럴 : 숫자, 문자열 등 고정된 값, 코드에 직접 포함되는 값.
            double y = 3.15;
            decimal z = 3.141592m;

            Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z); //여기서의 +는 연결 연산자.
            // 컴파일, 빌드의 개념 설명.

            // 문자열 : string => 1개 이상의 문자 사용 / "" 사용 (클래스)
            // 문자 : char(2바이트) => 단 1개의 문자 사용 / ''사용.
            string s = "안녕하세요.";
            char ch = '안';
            char ch1 = '녕';
            char ch2 = '하';
            char ch3 = '세';
            char ch4 = '요';
            Console.WriteLine(s);
            Console.WriteLine(ch+ch1+ch2+ch3+ch4); //250817이라는 결과가 나온다. 유니코드 값을 더한 결과값을 출력한 것이다. char를 숫자 대신으로도 쓸수 있음.
            Console.Write(ch);
            Console.Write(ch1);
            Console.Write(ch2);    
            Console.Write(ch3);
            Console.Write(ch4);
            Console.WriteLine(); //한 줄 띄우기

            // 논리형 : bool(1바이트) => true / false 값 사용
            bool isTest = true; //보통 앞에 is를 붙인다.
            Console.WriteLine(isTest);

            // object : 어떤 값이라도 할당할 수 있는 자료형. (클래스)
            // object 형식은 참조 형식 => 힙에 데이터를 할당한다.
            // 참조형식은 스택이 아니라 힙에 저장된다.

            object obj = 1;
            Console.WriteLine(obj);
            obj = 3.14;
            Console.WriteLine(obj);
            obj = "Hello";
            Console.WriteLine(obj);
            obj = 'h';
            Console.WriteLine(obj);
            obj = true; 
            Console.WriteLine(obj);

            // e = 3.14; => e는 정수형 변수인데 실수를 저장하려고 해서 에러.
            // e = "Hello";
            e = 'c'; // 'c'는 아스키 코드 값으로 저장 가능.
            Console.WriteLine(e); 
        }
    }
}
