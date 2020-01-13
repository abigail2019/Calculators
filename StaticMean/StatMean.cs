using System;
using StatOperations;
using Operation;
namespace StaticMean
{
    public interface IStatMean
    {
        public dynamic Mean(dynamic array);
    }
    public class StatMean:IStatMean
    {
        public dynamic result;
        public dynamic Mean(dynamic array)
        {
            result = StatOperations.StatOperations.Mean(array);
            return result;
        }
    }
}
