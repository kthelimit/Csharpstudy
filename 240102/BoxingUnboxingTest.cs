using System.Collections.Concurrent;

namespace BoxingUnboxingTest
{
    internal class BoxingUnboxingTest
    {
        static void Main(string[] args)
        {
            // 값형식과 참조형식
            // 변수 => 저장된 값의 메모리 주소
            // 2개의 메모리 영역 : 힙 / 스택 영역
            // 스택 영역 : 가장 마지막에 넣은 데이터를 먼저 꺼내는 선형적 구조. Last In First Out.
            // 힙 영역 : 계층적 구조 => 임의의 순서로 저장
            // 변수 선언시 스택에 공간이 할당.
            // => 스택에 값이 직접 저장되는 형식을 값형식이라고 한다.
            // => 힙에 값이 저장되는 형식을 참조형식이라고 한다.
            // 참조형식은 스택과 힙 메모리를 둘 다 사용함.
            // => 힙에는 실질적인 값을, 스택에는 값의 주소를 저장한다.
            // int(정수형 변수들) / float / double / decimal / bool / enum => 값형식.
            // string / object => 참조형식

            int a;
            // Console.WriteLine(a); => 에러 : a가 초기화되지 않음.
            string str;
            // Console.WriteLine(str); => 에러 : str이 초기화되지 않음.
            // a = null; => 에러 : int는 null값을 사용할 수 없다.
            str = null;
            // null 키워드 => 개체를 참조하지 않는 null 참조를 나타내는 리터럴.
            //            => 아무것도 참조하지 않는 값. => 참조 형식 변수의 기본값.

            // boxing : 값형식에서 object 형식으로 변환 => 내부에서 래필하고 힙에 저장 / 암시적(자동)
            // unboxing : object 형식에서 값형식으로 변환 => 명시적.

            // 박싱
            int i = 123; // 값형식
            //object obj => 참조형식, 힙 영역에 공간 생성
            object obj = i; // 암시적 박싱
            // object obj = (object) i; //명시적 박싱. 굳이 명시적으로 할 이유는 없다.

            //언박싱
            int j = (int)obj; //암시적 언박싱 object가 상위개념이라 한정해주는 것이다.
 
            Console.WriteLine(i);
            Console.WriteLine(obj); // 박싱
            Console.WriteLine(j); // 언박싱

        }
    }
}
