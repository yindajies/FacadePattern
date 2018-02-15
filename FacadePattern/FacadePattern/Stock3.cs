using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 股票3
    /// </summary>
    class Stock3
    {
        /// <summary>
        /// 卖股票
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("股票3卖出");
        }
        /// <summary>
        /// 买股票
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("股票3买入");
        }
    }
}
