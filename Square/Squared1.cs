using System;
using Operation;
namespace Square1
{
    public interface ISquared
    {
        public dynamic Squarea(dynamic a);
    }
    public class Squared1 : ISquared
    {
        public dynamic result;
        public dynamic Squarea(dynamic a)
        {
            result = Square.Squared(a);
            return result;
        }
    }
}
