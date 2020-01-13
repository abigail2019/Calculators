using System;
using StaticMean;
using StatOperations;
namespace Variances
{
    public interface IVariancesc
    {
        public dynamic Variance(dynamic array);
    }
    public class Variancesc: IVariancesc
    {
        public dynamic result;
        public dynamic Variance(dynamic array)
        {
            result = StatOperations.StatOperations.Variance(array);
            return result;
        }

    }
}
