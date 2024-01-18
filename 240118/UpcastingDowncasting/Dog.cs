using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
    internal class Dog : Animal
    {
        public string name = "강아지";

        public Dog()
        {
            Console.WriteLine("Dog 생성자 실행");
        }
        public override void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}
