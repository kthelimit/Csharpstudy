using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    internal class PropertyTest1
    {
        // 속성(property) : 필드의 값을 읽거나 쓰거나 계산하는 매커니즘을 제공하는 멤버
        // => 접근자라는 특수 메서드
        // => 데이터 접근을 쉽게 해서 안전하고 유연한 프로그래밍 가능.
        // get : 속성 값을 반환
        // set : 속성 값을 할당
        // value : set 접근자가 할당하는 값을 정의.

        // 필드 값을 반환하거나 할당만 하는 단순한 속성. 자동 구현 속성으로 구현가능.
        // => 코드 간소화 된다
        // => 속성에 get과 set 접근자가 모두 포함된 경우 두 접근자를 모두 자동구현해야한다.
        // => 자동 구현 속성을 사용할 때 필드 선언을 따로 할 필요는 없다.

        string name;
        public PropertyTest1(string name)
        {
            this.Name = name;
        }

        public int Age
        {
            get; 
            set;
        }
        public string Name { get; private set; }
        //private 걸은 건 생성자일땐 set이 된다.

        // 개체 이니셜라이저 => 멤버 초기화 가능
        // => 인스턴스를 생성하고 단일 명령문에서 멤버 할당을 가능하게 한다.
        // => 필드나 속성에 값을 할당 가능 / 객체 생성 가능

        //public string Name // 첫글자를 대문자로 함
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //} // get따로 set따로도 가능하다

    }
}
