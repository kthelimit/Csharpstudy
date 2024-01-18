using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Marine : TerranUnit
    {
        public int damage;

        //생성자
        public Marine()
        {
            Console.WriteLine("Marine 클래스 생성자 실행");
        }

        //클래스도 형변환이 있음... 부모클래스로 가는건 업캐스팅이라고 하는데 자연스럽게 됨.
        //자료형의 큰타입 작은 타입 간의 형변환과 비슷함
        public void Attack(TerranUnit target)
        {
            target.Hit(this.damage);
        }

    }
}
