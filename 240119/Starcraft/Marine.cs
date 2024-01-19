using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft
{
    internal class Marine : TerranUnit
    {
        public Marine()
        {
            Console.WriteLine("마린 클래스 생성자");
        }
        public override void Attack()
        {
            Console.WriteLine("마린이 공격을 합니다.");
        }

        public override void Init(string name, int maxHp)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = maxHp;
            Console.WriteLine($"이름 : {name}, 체력 : {hp}, 최대체력 : {maxHp}");
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
