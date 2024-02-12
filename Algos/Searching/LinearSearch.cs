using System;
using System.Collections.Generic;

namespace Algos
{
    public class LinearSearch<T> where T : IComparable<T>
    {
        private T[] _dataSet;
        private T _requiredElement;
    
        public LinearSearch(T[] dataSet, T requiredElement) 
        {
            _dataSet = dataSet;
            _requiredElement = requiredElement;
        }   

        public int SearchElement()
        {
            for(int i = 0; i < _dataSet.Length; i++)
            {
                if (_dataSet[i].CompareTo(_requiredElement) == 0)
                    return i;
            }
            return -1;
        }
    }
}
