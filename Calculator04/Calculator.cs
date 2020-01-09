using System;
using Operation;
using Divided;
using Add;
using Cubed;
using Multiply;
using Square1;
using SquareRoot;
using Subtract;

namespace Calculator
{
    public interface ICalculator
    {
        public dynamic Add(dynamic a, dynamic b); //Add is a function from the project Add and Class Sum

        public dynamic Cubed2(dynamic a); //D

        public dynamic Time(dynamic a, dynamic b); //D

        public dynamic Squarea(dynamic a);
        public dynamic Squared(dynamic a);
        public dynamic Subtracted(dynamic a, dynamic b);
        public dynamic Divided(dynamic a, dynamic b);
    }


    public class Calculator : ICalculator, ISquareRooted, IDiving, ISum, ICubed1, IMultiplying, ISquared, ISubtractby
    {
        public dynamic result;
        Dividing div = new Dividing(); //div is a construction //Dividing is a class name
        Sum add = new Sum();
        Cubed1 cub = new Cubed1();
        Multiplying mul = new Multiplying();
        Squared1 square = new Squared1();
        SquareRooted sr = new SquareRooted();
        Subtractby sub = new Subtractby();
        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b); //add is a construction//Add is a function Name
            return result;
        }
        public dynamic Divided(dynamic a, dynamic b)
        {
            result = div.Divided(a, b);
            return result;
        }
        public dynamic Cubed2(dynamic a)
        {
            result = cub.Cubed2(a);
            return result;
        }

        public dynamic Time(dynamic a, dynamic b)
        {
            result = mul.Time(a, b);
            return result;
        }
        public dynamic Squarea(dynamic a)
        {
            result = square.Squarea(a);
            return result;
        }
        public dynamic Squared(dynamic a)
        {
            result = sr.Squared(a);
            return result;
        }
        public dynamic Subtracted(dynamic a, dynamic b)
        {
            result = sub.Subtracted(a, b);
            return result;
        }
    }
}
