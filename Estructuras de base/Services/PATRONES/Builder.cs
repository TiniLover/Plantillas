using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public class Products
    {
        public string PartA { get; set; }
        public string PartB { get; set; }

        public void Show() => Console.WriteLine($"{PartA}, {PartB}");
    }

    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA() => _product.PartA = "Part A built";
        public void BuildPartB() => _product.PartB = "Part B built";
        public Product GetResult() => _product;
    }

    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

}
