using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal interface IZerg
    {
        // 인터페이스 : 사용자 정의 형식 => 추상화를 구현하는 방식 중 하나
        // 추상 : 여러 사물이나 개념 따위의 개별자들로부터 공통점을 파악하고 추려내는 것.
        // interface 이름 => 인터페이스 이름은 첫글자를 대문자 I로 하는 것이 관계이다.
        // {
        //      메서드 정의; => 본문이 없는 메서드
        // }
        // => 인터페이스는 필드를 포함할 수 없다.
        // => 인터페이스 멤버에 접근제한자를 사용할 수 없다.
        // => 기본적으로 공개되어 있음(public이 디폴트)
        // => 인터페이스는 다중 상속이 가능하다.
        // => 인터페이스를 구현하는 클래스는 인터페이스에 선언된 메서드를 모두 구현해야한다. => override
        // => 세부사항을 숨기고 특정 기능을 제공하고 다중상속을 위해 사용

        void RecoveryHp();
        void Burrow();

    }
}
