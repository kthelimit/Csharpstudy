using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Medic : TerranUnit
    {
        public int healValue;
        //생성자
        public Medic()
        {
            Console.WriteLine("Medic 클래스 생성자 실행");
        }
        public void Heal(TerranUnit target)
        {
            target.AddHp(healValue);
        }
    }
}
