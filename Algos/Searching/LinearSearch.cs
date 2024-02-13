using System;
using System.Collections.Generic;

namespace Algos
{
    internal class LinearSearch<T>
    {
        private T[] _dataSet;
        private T _requiredElement;
        private Dictionary<T, int> _hashTable = new();
        public LinearSearch(T[] dataSet, T requiredElement) 
        {
            _dataSet = dataSet;
            _requiredElement = requiredElement;
        }   

        public int SearchElement()
        {
            for(int i = 0; i < _dataSet.Length; i++)
            {
                //if (_dataSet[i].CompareTo(_requiredElement) == 0)
                //    return i;
                if(EqualityComparer<T>.Default.Equals(_dataSet[i], _requiredElement))
                    return i;
            }
            return -1;
        }

        public int SearchHashedElement()
        {
            for(int i = 0; i < _dataSet.Length; i++)
            {
                _hashTable.Add(_dataSet[i], i);
            }

            if(_hashTable.ContainsKey(_requiredElement))
                return _hashTable[_requiredElement];
            else
                return -1;
        }
    }
}
