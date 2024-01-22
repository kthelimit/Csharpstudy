using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Hydralisk : IZerg, IMetamorph
    {
        //인터페이스는 다중 상속이 가능하다. "," 로 추가해주면 된다.
        public int damage = 3;
        public void Burrow()
        {
            Console.WriteLine("땅속에 숨습니다.");
        }

        public void Morph(string name)
        {
            Console.WriteLine($"{name}으로 변형합니다.");
        }

        public void RecoveryHp()
        {
            Console.WriteLine("상처를 재생합니다.");
        }
    }
}
