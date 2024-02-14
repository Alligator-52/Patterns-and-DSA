using System;
using System.Collections.Generic;
using System.Linq;

namespace Algos
{
    /// <summary>
    /// for sorted arrays
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class BinarySearch<T>
    {
        private T[] _dataset;
        private T _requiredElement;

        public BinarySearch(T[] dataSet, T required)
        {
            _dataset = dataSet;
            _requiredElement = required;
        }

        public T BinarySearch()
        {
            if (!IsSorted())
                Array.Sort(_dataset);

            int low = 0;
            int high = _dataset.Length - 1;

            for(int i = 0; i < _dataset.Length - 1; i++)
            {
                int mid = low + (high - 1) / 2;

                if (_dataset[mid] == _requiredElement)
                    return mid;
                else if (_dataset[mid] < _requiredElement)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }

        private bool IsSorted()
        {
            for (int i = 0; i < _dataset.Length - 1; i++)
            {
                if (_dataset[i] > _dataset[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
