using System;
using StatOperations;
using Calculator04;
using StaticMean;
namespace StatisticsCalculator
{
    public class StatCalculator : Calculator, IStatMean
    {
        StatMean mean = new StatMean();
        public dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
    }

    }
}
