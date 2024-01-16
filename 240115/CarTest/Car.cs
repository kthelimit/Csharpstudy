using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    // 클래스 : 사용자 정의 자료형 => 객체를 생성하기 위해 변수와 메서드를 정의하는 틀.(청사진. 설계도)
    // => 클래스는 객체를 생성하는데 사용된다.
    // => 클래스에는 객체의 속성과 기능이 정의되어 있다.
    // 객체(인스턴스) : 클래스로부터 생성되어 메모리에 저장된 값.
    // => 객체는 고유한 속성을 가지며 클래스에서 정의한 기능을 수행할 수 있다.
    // => 객체의 구성요소에는 속성(멤버 변수, 필드)와 기능(메서드)이 있다

    // class 클래스명 {
    //      클래스에서 정의된 속성과 기능;
    // }
    internal class Car
    {
        // 클래스 내부에서 선언된 변수를 속성, 필드, 멤버 변수라고 한다.
        public string name; // 속성, 필드, 멤버 변수

        public void MoveForward()
        {
            Console.WriteLine("{0}이(가) 전진합니다.", name);
        }



    }
}
