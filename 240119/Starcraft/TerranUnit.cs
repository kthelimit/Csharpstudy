using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft
{
    internal abstract class TerranUnit //추상클래스
    {
        public int hp;
        public int maxHp;
        protected string name;
        public TerranUnit()
        {
            Console.WriteLine("abstract 클래스 생성자");
        }
        public abstract void Attack(); //추상메서드
        public abstract void Init(string name, int maxHp); //추상메서드
        public void Hit(int damage)
        {
            this.hp -= damage;
            Console.WriteLine("{0}이 피해({1})를 받았습니다.",this.name, damage);
        }
    }
}
