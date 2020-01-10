using System;
using StatOperations;
namespace StaticMean
{
    public interface IStatMean
    {
        public dynamic Mean(dynamic a);
    }
    public class StatMean:IStatMean
    {
        public dynamic result;
        public dynamic Mean(dynamic a)
        {
            result = StatOperations.StatOperations.Mean(a);
            return result;
        }
    }
}
