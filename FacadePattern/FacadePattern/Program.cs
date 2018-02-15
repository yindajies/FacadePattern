using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 外观（门面）模式：为子系统的一组接口提供一个一致的界面，此模式定义了一个高层接口，这个接口似的使得这一子系统更加容易使用。
    /// 优点：完美地体现了依赖倒转原则和迪米特原则的思想，所以是非常常用的模式之一
    /// </summary>
    class Program
    {
        /// <summary>
        /// 股民炒股
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stock1 gu1 = new Stock1();
            Stock2 gu2 = new Stock2();
            Stock3 gu3 = new Stock3();

            gu1.Sell();
            gu2.Sell();
            gu3.Sell();

            gu1.Buy();
            gu2.Buy();
            gu3.Buy();

            Fund jijin = new Fund();
            //基金购买
            jijin.BuyFund();
            //基金赎回
            jijin.SellFund();

            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            Console.Read();
        }
    }
}
