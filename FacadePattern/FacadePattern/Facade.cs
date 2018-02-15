using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 外观类
    /// </summary>
    class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine("方法组A()");
            one.MethodOne();
            two.MethodTwo();
        }
        public void MethodB()
        {
            Console.WriteLine("方法组B()");
            three.MethodThree();
            one.MethodOne();
        }
    }
}
