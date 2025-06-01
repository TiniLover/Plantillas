using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void Execute() => Console.WriteLine("Strategy A");
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute() => Console.WriteLine("Strategy B");
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy) => _strategy = strategy;

        public void SetStrategy(IStrategy strategy) => _strategy = strategy;

        public void ExecuteStrategy() => _strategy.Execute();
    }

}
