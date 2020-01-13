using System;

namespace StandardDeviation
{
    public interface IStandardDiv
    {
        public dynamic StandardD(dynamic d);
    }
    public class StandardDiv:IStandardDiv
    {
        public dynamic result;
        public dynamic StandardD(dynamic d)
        {
            result = StatOperations.StatOperations.StandardD(d);
            return result;
        }

    }
}
