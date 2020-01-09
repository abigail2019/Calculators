using System;
using Operation;
namespace Subtract
{
   
        public interface ISubtractby
        {
            public dynamic Subtracted(dynamic a, dynamic b);
        }
        public class Subtractby : ISubtractby
        {
            public dynamic results;
            public dynamic Subtracted(dynamic a, dynamic b)
            {
                results = Subtraction.Subtract(a, b);
                return results;
            }
        }
}
