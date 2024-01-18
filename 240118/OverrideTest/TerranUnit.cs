using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTest
{
    internal class TerranUnit
    {
        public string name;
        //생성자
        public TerranUnit()
        {
            Console.WriteLine("TerranUnit 생성자 실행");
        }

        public virtual void Attack() // virtual이기 때문에 상속받는 클래스에서 재정의 가능
        {         
            Console.WriteLine("{0}이(가) 공격합니다.", name);
        }

        protected void Reload(string weaponName)
        {
            Console.WriteLine("{0}이(가) {1}을(를) 장전합니다.", this.name, weaponName);
        }
    }
}
