using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTapTuan01
{
    /// <summary>
    /// Manages operations on a one-dimensional integer array
    /// </summary>
    public class IntegerArrayManager
    {
        private List<int> _data;

        /// <summary>
        /// Gets the array data
        /// </summary>
        public int[] Array => _data.ToArray();

        /// <summary>
        /// Gets the count of elements in array
        /// </summary>
        public int Count => _data.Count;

        /// <summary>
        /// Initializes a new instance with optional initial elements
        /// </summary>
        public IntegerArrayManager(params int[] initialValues)
        {
            _data = new List<int>(initialValues ?? System.Array.Empty<int>());
        }

        /// <summary>
        /// Initializes the array from a collection
        /// </summary>
        public void Initialize(IEnumerable<int> values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values), "Values cannot be null");

            _data = new List<int>(values);
        }

        /// <summary>
        /// Sorts the array in ascending order
        /// </summary>
        public void SortAscending()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot sort an empty array");

            _data.Sort();
        }

        /// <summary>
        /// Sorts the array in descending order
        /// </summary>
        public void SortDescending()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot sort an empty array");

            _data.Sort((a, b) => b.CompareTo(a));
        }

        /// <summary>
        /// Searches for a value in the array and returns all matching indices
        /// </summary>
        public List<int> SearchValue(int value)
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot search in an empty array");

            return _data
                .Select((val, index) => new { val, index })
                .Where(x => x.val == value)
                .Select(x => x.index)
                .ToList();
        }

        /// <summary>
        /// Adds a new value at a specified position (0-based index)
        /// </summary>
        public void InsertAt(int index, int value)
        {
            if (index < 0 || index > _data.Count)
                throw new ArgumentOutOfRangeException(nameof(index), 
                    $"Index must be between 0 and {_data.Count}");

            _data.Insert(index, value);
        }

        /// <summary>
        /// Removes an element at the specified index
        /// </summary>
        public void RemoveAt(int index)
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot remove from an empty array");

            if (index < 0 || index >= _data.Count)
                throw new ArgumentOutOfRangeException(nameof(index), 
                    $"Index must be between 0 and {_data.Count - 1}");

            _data.RemoveAt(index);
        }

        /// <summary>
        /// Calculates the sum of all elements
        /// </summary>
        public long GetSum()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot calculate sum of an empty array");

            return _data.Sum(x => (long)x);
        }

        /// <summary>
        /// Calculates the sum of even numbers
        /// </summary>
        public long GetEvenSum()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot calculate sum of an empty array");

            return _data.Where(x => x % 2 == 0).Sum(x => (long)x);
        }

        /// <summary>
        /// Calculates the sum of odd numbers
        /// </summary>
        public long GetOddSum()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot calculate sum of an empty array");

            return _data.Where(x => x % 2 != 0).Sum(x => (long)x);
        }

        /// <summary>
        /// Finds the maximum value in the array
        /// </summary>
        public int GetMaxValue()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot find max of an empty array");

            return _data.Max();
        }

        /// <summary>
        /// Finds the minimum value in the array
        /// </summary>
        public int GetMinValue()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot find min of an empty array");

            return _data.Min();
        }

        /// <summary>
        /// Replaces all occurrences of a value with a new value
        /// </summary>
        public int ReplaceValue(int oldValue, int newValue)
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot replace in an empty array");

            int count = 0;
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i] == oldValue)
                {
                    _data[i] = newValue;
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Replaces the element at a specific index with a new value
        /// </summary>
        public void ReplaceAtIndex(int index, int newValue)
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Cannot replace in an empty array");

            if (index < 0 || index >= _data.Count)
                throw new ArgumentOutOfRangeException(nameof(index), 
                    $"Index must be between 0 and {_data.Count - 1}");

            _data[index] = newValue;
        }

        /// <summary>
        /// Gets element at specified index
        /// </summary>
        public int GetAt(int index)
        {
            if (index < 0 || index >= _data.Count)
                throw new ArgumentOutOfRangeException(nameof(index), 
                    $"Index must be between 0 and {_data.Count - 1}");

            return _data[index];
        }

        /// <summary>
        /// Clears all elements from the array
        /// </summary>
        public void Clear()
        {
            _data.Clear();
        }

        /// <summary>
        /// Returns a string representation of the array
        /// </summary>
        public override string ToString()
        {
            if (_data.Count == 0)
                return "[]";

            return $"[{string.Join(", ", _data)}]";
        }
    }
}
