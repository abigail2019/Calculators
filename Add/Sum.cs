﻿using System;
using Operation;
namespace Add
{
    public interface ISum
    {
        public dynamic Add(dynamic a, dynamic b);
    }
    public class Sum : ISum
    {
        public dynamic result;
        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }
    }
}
