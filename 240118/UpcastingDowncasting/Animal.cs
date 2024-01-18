using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
    internal class Animal
    {
        public string name = "동물";

        public Animal()
        {
            Console.WriteLine("Animal 생성자 실행");

        }
        public virtual void Bark()
        {
            Console.WriteLine("동물들은 짖습니다.");
        }

    }
}
