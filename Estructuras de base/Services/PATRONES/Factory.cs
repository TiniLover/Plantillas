using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public abstract class Product
    {
        public abstract string GetName();
    }

    public class ConcreteProductA : Product
    {
        public override string GetName() => "Product A";
    }

    public class ConcreteProductB : Product
    {
        public override string GetName() => "Product B";
    }

    public abstract class Creator
    {
        public abstract Product CreateProduct();
    }

    public class CreatorA : Creator
    {
        public override Product CreateProduct() => new ConcreteProductA();
    }

    public class CreatorB : Creator
    {
        public override Product CreateProduct() => new ConcreteProductB();
    }

}
