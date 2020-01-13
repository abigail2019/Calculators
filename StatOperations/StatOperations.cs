using System;
using Operation;
namespace StatOperations
{
    public class StatOperations
    {
        public static dynamic result;
        public static dynamic Mean(dynamic array)
        {

            var sum = Addition.Sum(array);
            var valueCount = Helpers.Array.Length(array);
            dynamic results = Division.Divsion(sum, valueCount);
            //result = Helpers.Rounding.RoundOffTwoPlaces(results);
            return results;
        }
        public static dynamic Variance(dynamic array)
        {
            //var sum = Addition.Sum(array);
            var valueCount = Helpers.Array.Length(array);
            dynamic a = StatOperations.Mean(array);
            dynamic c = array[0];

            for (int d = 1; d < array.Length; d++)
            {
                c += Math.Pow((array[d] - a), 2);
            }
            //dynamic a = StatOperations.Mean(array);
            //dynamic sub = Subtraction.Subtract(c,a);
            //dynamic Squa = Square.Squared(sub);
            dynamic results = Division.Divsion(c,valueCount);

            result = Helpers.Rounding.RoundOffTwoPlaces(results);

            return result; 

        }
        public static dynamic StandardD(dynamic d)
        {
            
            //var sum = Addition.Sum(array);
            var a = StatOperations.Variance(d);
            //var valueCount = Helpers.Array.Length(array);
            dynamic results = SuareRoot.Root(a);
            //result = Helpers.Rounding.RoundOffTwoPlaces(results);
            return results;
        }

    }
}
