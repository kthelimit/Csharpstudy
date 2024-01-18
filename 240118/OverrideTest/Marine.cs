using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTest
{
    internal class Marine : TerranUnit
    {
        public Marine() { Console.WriteLine("Marine 생성자 실행"); }
        public override void Attack()
        {
            base.Reload("총");
            //base.Attack();
            Console.WriteLine($"{this.name}이(가) 총으로 공격");
        }
    }

}
