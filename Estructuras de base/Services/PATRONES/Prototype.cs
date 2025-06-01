using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class ConcretePrototype : Prototype
    {
        public int Data { get; set; }

        public override Prototype Clone() => (Prototype)this.MemberwiseClone();
    }

}
