using System;
using System.Collections.Generic;

namespace Algos
{
    public class LinearSearch
    {
        private int[] _dataSet;
    
        public LinearSearch(int[] dataSet) 
        {
            _dataSet = dataSet;
        }   

        public int SearchElement(int requiredElement)
        {
            for(int i = 0; i < _dataSet.Length; i++)
            {
                if (_dataSet[i] == requiredElement)
                    return _dataSet[i];
            }
            return -1;
        }
    }
}
