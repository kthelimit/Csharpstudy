using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingTest
{
    internal class TerranUnit
    {
        // 업캐스팅 : 인스턴스의 타입을 파생크랠스 타입에서 기본클래스 타입으로 변환.
        // => 업캐스팅 암시적(자동형변환. 작은타입->큰타입... 즉 자식에서 부모클래스로.)
        //(부모클래스) 이런식으로 명시적으로 해도 됨.

        // 다운캐스팅 : 인스턴스의 타입을 기본 클래스 타입에서 파생클래스 타입으로 변환
        // => 다운캐스팅 명시적(강제형변환)
        // => 부모타입으로 업캐스팅했던 인스턴스만 가능함.(아무나 되는건 아니다)

        // 접근가능한 멤버는 참조변수의 타입에 의해 결정.
        // => 업캐스팅을 하면 자식객체의 멤버는 사용불가.
        // => 자식클래스에서 override한 메서드가 있다면 부모의 메서드가 아닌 자식 메서드를 사용
        

        //다형성을 위해?(같은코드를 갖고 다양한 결과를 내는 것?)

        public void Attack()
        {
            Console.WriteLine("공격합니다.");
        }


    }
}
