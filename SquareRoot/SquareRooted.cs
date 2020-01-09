using System;
using Operation;
namespace SquareRoot
{
    public interface ISquareRooted
    {
        public dynamic Squared(dynamic a);
    }
    public class SquareRooted : ISquareRooted
    {
        public dynamic result;
        public dynamic Squared(dynamic a)
        {

            result = SuareRoot.Root(a);
            return result;
        }
    }
}
