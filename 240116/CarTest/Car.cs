using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    internal class Car
    {
        // 생성자 : 클래스 내부에서 정의된 특수한 메서드
        // => 생성자 이름은 클래스 이름과 동일함
        // => 이름과 매개변수만 포함하고 반환형식(리턴값)은 포함되지 않는다.
        // => 접근 제한자가 없다면 기본적으로 private
        // => private으로 되어 있으면 외부에서 객체 생성을 할 수가 없다.
        // => 생성자는 객체 생성시 자동으로 호출
        // => 생성자를 이용해서 멤버 변수의 기본값을 설정할 수 있다.
        // => 매개변수 선언
        // => 메서드를 사용할 수 있게 한다.

        public string name;
        public string color;
        public int maxSpeed;
        public Car()
        {
            Console.WriteLine("생성자 메서드 호출됨.");
        }
        //Car라는 메서드가 여러개 : 메서드 오버로딩
        // 매개변수 개수가 다르거나 타입이 다르면...
        public Car(string carName)
        {
            Console.WriteLine("매개변수가 있는 생성자가 호출됨");
            //매개변수 출력
            Console.WriteLine("매개변수 : {0}", carName);
            //멤버변수 출력
            //멤버변수에 어떤 값도 할당하지 않아씩 때문에 null값이 나옴.
            Console.WriteLine("맴버변수 : {0}", name);

            // 생성자 호출이 완료되면 매개변수의 값을 사라진다.
            // => 매개변수의 값을 멤버변수에 할당한다..
            name = carName;
            Console.WriteLine("맴버변수 : {0}", name);

            // 멤버변수는 인스턴스를 더이상 참조하지 않으면 가비지 컬렉터가 메모리에서 해제한다.
        }

        public Car(string carName, string carColor)
        {
            Console.WriteLine("매개변수가 2개인 생성자가 실행이 됩니다.");
            Console.WriteLine("매개변수 : {0}", carName);
            Console.WriteLine("매개변수 : {0}", carColor);
            name = carName;
            color = carColor;
            Console.WriteLine("멤버변수 : {0}", name);
            Console.WriteLine("멤버변수 : {0}", color);
        }

        public Car(int maxSpeed)
        {
            // this 키워드 : 현재 클래스를 의미한다.
            // => 클래스 내부의 메서드 또는 생성자에서 현재 클래스의 멤버(변수든 메서드든)를
            // 참조하는데 사용된다.
            this.maxSpeed = maxSpeed;
        }




    }
}
