using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 福特汽车建造
    /// </summary>
    class BuilderFord : AbstractBuilder
    {
        private string _Engine = null;
        private string _Wheels = null;
        private string _Light = null;

        public override void Engine()
        {
            _Engine = "_Engine";
            Console.WriteLine("{0} builder Engine",this.GetType().Name);
        }
        public override void Wheels()
        {
            _Wheels = "_Wheels";
            Console.WriteLine("{0} builder Wheels", this.GetType().Name);
        }
        public override void Light()
        {
            _Light = "_Light";
            Console.WriteLine("{0} builder Light", this.GetType().Name);
        }
        public override void Car()
        {
            Console.WriteLine("{0}{1}{2}",this._Engine,this._Wheels,this._Light);
            Console.WriteLine("{0} builder Mondeo", this.GetType().Name);
        }
    }
}
