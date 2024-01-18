using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TerranUnit : StarcraftUnit
    {
        protected int hp;
        protected int maxHp;

        public TerranUnit()
        {
            Console.WriteLine("TerranUnit 클래스 생성자 실행");
        }

        public void Init(string name, int maxHp)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = maxHp;
        }

        public void Hit(int damage)
        {
            this.hp -= damage;
            Console.WriteLine("{0}가(이) 피해({1})를 받았습니다.", this.name, damage);
        }

        public void AddHp(int healValue)
        {
            this.hp += healValue;
            Console.WriteLine("{0}의 체력이 회복되었습니다.", this.name);
            if(this.hp >= maxHp)
            {
                this.hp = maxHp;
            }
        }

        public int GetHp()
        {
            return this.hp;
        }
    }
}
