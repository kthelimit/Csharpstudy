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

        }
    }
}
