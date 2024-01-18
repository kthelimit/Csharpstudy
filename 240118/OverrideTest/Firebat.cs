using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTest
{
    internal class Firebat : TerranUnit
    {
        public Firebat() { Console.WriteLine("Firebat 생성자 실행"); }

        public override void Attack()
        {
            //base 키워드는 파생클래스 내에서 기본 클래스의 멤버에 액세스하는데 사용.
            base.Reload("화염방사기");
            Console.WriteLine($"{this.name}이(가) 화염방사기로 공격");
            base.Attack();
        }

    }
}
