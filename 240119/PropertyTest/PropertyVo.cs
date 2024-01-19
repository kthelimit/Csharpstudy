using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    internal class PropertyVo
    {
        // property(프로퍼티) : 속성이란 의미 => 속성값을 반환하거나 새값을 할당할 수 있다.
        // 접근제한자 데이터타입 프로퍼티명 {
        //  get
        //  {
        //          return 반환값;
        //  }
        //  set
        //  {
        //          멤버변수 = value;
        //  }
        // }

        private int a;
        private int b;
        private string c;

        public int d
        {
            get { return a; }
            set { this.a = value; }
        }

        public string name_ { get; set; } = "개똥이";
    }
}
