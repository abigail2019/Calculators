using System;
using StatOperations;
using Calculator04;
using StaticMean;
using Variances;
using StandardDeviation;
namespace StatisticsCalculator
{
    
    public class StatCalculator : Calculator, IStatMean, IVariancesc, IStandardDiv
    {
        //public dynamic result1;
        readonly StatMean mean = new StatMean();
        readonly Variancesc vari = new Variancesc();
        readonly StandardDiv sd = new StandardDiv();

        public dynamic Mean(dynamic array)
        {
            //result = StatOperations.StatOperations.Mean(array);
           result = mean.Mean(array);
           return result;
        }
        public dynamic Variance(dynamic array)
        {
            //result = StatOperations.StatOperations.Mean(array);
            result = vari.Variance(array);
            return result;
        }
        public dynamic StandardD(dynamic d)
        {
            //result = StatOperations.StatOperations.Mean(array);
            result = sd.StandardD(d);
            return result;
        }
    }
}
