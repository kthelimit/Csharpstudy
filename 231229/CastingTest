using System;
using System.Runtime.CompilerServices;

namespace CastingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "+"의 역할 : 숫자 + 숫자 => 산술 연산. 
            // 숫자 + 문자 => 연결 연산자의 역할.
            Console.WriteLine("5 + 3 =" + 5 + 3);
            Console.WriteLine(5 + 3);
            Console.WriteLine(5 + 3 + " = 5 + 3");
            Console.WriteLine("5 + 3 =" + (5 + 3));
            Console.WriteLine("5 * 3 = " + 5 * 3);
            // 정수와 정수의 연산 결과는 정수이다.
            Console.WriteLine("5 / 3 = " + 5 / 3);
            // 정수와 실수의 연산 결과는 실수(정수를 실수로 형변환함)
            Console.WriteLine("5.0 / 3 = " + 5.0 / 3);
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 % 3 = " + 5 % 3); // 나머지
            Console.WriteLine("5.0 / 3.0 = " + 5.0 / 3.0);
            Console.WriteLine("5 / 3.0 = " + 5 / 3.0);
            Console.WriteLine("=======================");
            // 정수 > 실수 자연적으로 형변환됨. 그 반대는 안됨...

            // 형변환 : 변수 또는 상수 타입의 변수를 다른 타입으로 변환하는 것.
            // 암시적형변환(자동 형변환) : 특수 구문 필요없음
            // => 자료형의 크기가 서로 다른 경우 작은 쪽의 타입을 큰 쪽으로 자동 변환하는 것.
            int myInt = 36;
            float myFloat = 16.46f;
            myFloat = myInt + myFloat;
            // => 연산이 일어나기 전에 myInt는 float 타입으로 변환된다
            Console.WriteLine(myFloat);

            long l = 134901930;
            short s = 516;
            double d = l - s;
            // "-" 연산자는 long 타입값에서 s값만 빼기만 함
            // "=" 연산자가 연산 결과를 double 타입으로 변환한다.
            Console.WriteLine(d);
            d = d / 123;
            Console.WriteLine(d);

            long number = 139401930;
            string text = "점수 : " + number;
            // => "+" 연산자를 이용해 문자열과 문자열이 아닌 타입을 연결하면 자동으로 문자열로 변환한다.
            // text = number; // 에러
            Console.WriteLine(text);

            Console.WriteLine("A + 32 = " + ('A' + 32));
            Console.WriteLine("a - 32 = " + ('a' - 32));
            Console.WriteLine("=======================");

            Console.WriteLine("A + 32 = " + (char)('A' + 32));
            Console.WriteLine("a - 32 = " + (char)('a' - 32));

            // 강제 형변환(명시적 형변환) : 캐스트 식이 필요.
            // => (변환할 타입)변수

            float myFloatValue = 10.53f;
            Console.WriteLine(myFloatValue);
            int myIntValue = (int)myFloatValue;
            Console.WriteLine("myIntValue is " + myIntValue);

            // int형 값을 byte 타입에 캐스팅을 한 경우 오류는 나지 않지만 최대값을 초과하게 되면 변수 값이 최솟값으로 초기화된다.
            //byte의 최대값인 255를 넘어가면 0이 되고 거기서부터 다시 셈... 그래서 365가 109가 되고 256이 0이 된다.
            int myIntValue2 = 365;
            byte myByte = (byte)myIntValue2;
            Console.WriteLine(myByte);
            myIntValue2 = 256;
            myByte = (byte)myIntValue2;
            Console.WriteLine(myByte);
            myIntValue2 = 257;
            myByte = (byte)myIntValue2;
            Console.WriteLine(myByte);

            myInt = 10;
            myByte = (byte)myInt;
            double myDouble = (double)myByte; // 자동으로도 되지만 강제로도 된다는 것임...
            bool myBool = true;
            // myBool = (bool)myDouble; // 에러 : double은 bool로 변환불가
            // myByte = (byte)myBool; // 에러 : bool은 byte로 변환불가.
            short myShort = (short)myInt;
            char myChar = 'x';
            string myString = "false";
            // myBool = (bool)myString; //에러 : bool 타입에 string이 안들어감
            // bool타입은 형변환이 안 된다...
            // myString = (string)myBool;// 에러
            // myString = (string)myChar; // 에러 : 한 글자는 문자열로 강제형변환이 안된다....
            // ToString() : 해당 객체를 문자열로 변환하는 메소드.
            // => 모든 객체가 가지고 있다.
            myString = myChar.ToString(); // 이건 에러가 안남 
            //myString = (string)myInt; //에러
            myString = myInt.ToString();
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;

            myString = myString + myInt + myByte + myDouble + myChar;
            Console.WriteLine(myString);

        }
    }
}
