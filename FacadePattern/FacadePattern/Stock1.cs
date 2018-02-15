using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 股票1
    /// </summary>
    class Stock1
    {
        /// <summary>
        /// 卖股票
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("股票1卖出");
        }
        /// <summary>
        /// 买股票
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("股票1买入");
        }
    }
}
