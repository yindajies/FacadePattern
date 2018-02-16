using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class AbstractBuilder
    {
        public abstract void Engine();
        public abstract void Wheels();
        public abstract void Light();
        public abstract void Car();
    }
}
