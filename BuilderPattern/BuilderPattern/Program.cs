using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 建造者模式：复杂的构建与其表示相分离，使得同样的构建可以产生不同的表示，固定流程。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            {
                AbstractBuilder ford = new BuilderFord();
                ford.Engine();
                ford.Wheels();
                ford.Light();
                ford.Car();

                AbstractBuilder bmw = new BuilderBMW();
                bmw.Engine();
                bmw.Wheels();
                bmw.Light();
                bmw.Car();
            }

            Console.WriteLine("************************升级**************************");
            {
                AbstractBuilder ford2 = new BuilderFord();
                Director dir = new Director(ford2);
                dir.GetCar();
            }
            Console.Read();
        }
    }
}
