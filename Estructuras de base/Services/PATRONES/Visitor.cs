using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }

    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA element) => Console.WriteLine("Visited A");
        public void Visit(ElementB element) => Console.WriteLine("Visited B");
    }

}
