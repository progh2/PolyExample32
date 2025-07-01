using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample32
{
    class Dog : Animal
    {
        public void TestB()
        {
            Protected();    // 상속된 자식에서는 proected 접근 가능
            Public();
        }
        public string Color { get; set; }

        public sealed override void Sleep() { Console.WriteLine("드르렁 드르렁 잠을 잡니다."); }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }

    }
}
