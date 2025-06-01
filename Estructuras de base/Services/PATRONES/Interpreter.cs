using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface IExpression
    {
        int Interpret();
    }

    public class Number : IExpression
    {
        private int _value;

        public Number(int value) => _value = value;

        public int Interpret() => _value;
    }

    public class Add : IExpression
    {
        private IExpression _left, _right;

        public Add(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret() => _left.Interpret() + _right.Interpret();
    }

}
