using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 基金类
    /// </summary>
    class Fund
    {
        Stock1 gu1;
        Stock2 gu2;
        Stock3 gu3;

        public Fund()
        {
            gu1 = new Stock1();
            gu2 = new Stock2();
            gu3 = new Stock3();
        }

        public void BuyFund()
        {
            gu1.Buy();
            gu2.Buy();
            gu3.Buy();
        }
        public void SellFund()
        {
            gu1.Sell();
            gu2.Sell();
            gu3.Sell();
        }
    }
}
