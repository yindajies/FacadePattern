using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 指挥者，分配
    /// </summary>
    class Director
    {
       private AbstractBuilder _builder = null;

        public Director(AbstractBuilder builder)
        {
            this._builder = builder;
        }

        public void GetCar()
        {
            this._builder.Engine();
            this._builder.Wheels();
            this._builder.Light();
            this._builder.Car();
        }
    }
}
