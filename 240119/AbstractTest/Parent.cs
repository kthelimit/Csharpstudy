using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    abstract class Parent // 추상 클래스
    {
        public string name = "Tom";
        public Parent() //생성자 선언
        {
            Console.WriteLine("Abstract 클래스 생성자");
        }

        public abstract void printName(); //추상 메서드
        public void nomalMethod() //일반 메서드
        {
            Console.WriteLine("Parent 클래스의 일반 메서드입니다.");
        }

    }



    internal class AbstractTest1 : Parent
    {
        // 추상 클래스 : 여러 파생 클래스에서 공유할 수 있는 기본 클래스의
        // 공통적인 정의를 제공
        // 미완성된 클래스 => 추상 메서드(미완성된 메서드)를 포함하고 있기 때문에....
        // => 추상메서드 : 추상 클래스에서만 선언할 수 있고, 메서드의 본문이 없다.
        // 메서드의 본문이 없다. =? abstract 사용 / 가상메서드
        // => 추상클래스의 파생클래스에서 추상 메서드를 모두 구현해야한다.=> override해야한다
        // => 추상메서드를 선언할 때 static 또는 virtual 키워드를 사용할 수 없다.
        // => 직접 인스턴스화 할 수 없다(객체 생성 불가..) => new 사용못함
        // 추상클래스에서 선언되는 모든 멤버는 접근 제한자를 지정하지 않으면 모두 private이다.
        // abstract class 클래스명 {
        // }
        // 추상 클래스도 일반 클래스를 상속할 수 있다.
        public override void printName() // 기본클래스의 추상메서드를 재정의
        {
            Console.WriteLine("이름 : {0}", name);
        }
    }
}
