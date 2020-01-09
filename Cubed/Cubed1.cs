using System;
using Operation;
namespace Cubed
{
    public interface ICubed1
    {
        public dynamic Cubed2(dynamic a);
    }
    public class Cubed1 : ICubed1
    {
        public dynamic result;
        public dynamic Cubed2(dynamic a)
        {
            result = Cube.Cubed(a);
            return result;
        }

    }
}
