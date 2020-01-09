using System;
using Operation;
namespace Multiply
{
    public interface IMultiplying
    {
        public dynamic Time(dynamic a, dynamic b);
    }
    public class Multiplying : IMultiplying
    {
        public dynamic result;
        public dynamic Time(dynamic a, dynamic b)
        {
            result = Multiplication.Multiply(a, b);
            return result;
        }
    }
}
