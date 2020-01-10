using System;
using Operation;
namespace StatOperations
{
    public class StatOperations
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Sum(values);
            var valueCount = values.Length;
            var result = Division.Divsion(sum, valueCount);
            return result;
        }
    }
}
