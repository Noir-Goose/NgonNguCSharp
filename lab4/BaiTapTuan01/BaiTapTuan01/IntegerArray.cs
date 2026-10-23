using System;
using System.Collections.Generic;

namespace BaiTapTuan01
{
    /// <summary>
    /// Lớp quản lý mảng một chiều số nguyên với các phương thức xử lý mảng
    /// </summary>
    public class IntegerArray
    {
        private int[] array;

        /// <summary>
        /// Khởi tạo mảng từ danh sách các số nguyên
        /// </summary>
        public IntegerArray(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
                throw new ArgumentException("Mảng không được rỗng.");

            array = (int[])inputArray.Clone();
        }

        /// <summary>
        /// Khởi tạo mảng từ chuỗi các số được ngăn cách bằng khoảng trắng
        /// </summary>
        public IntegerArray(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Dữ liệu nhập không được rỗng.");

            try
            {
                string[] parts = input.Trim().Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 0)
                    throw new ArgumentException("Không có phần tử nào trong mảng.");

                array = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out array[i]))
                        throw new FormatException($"'{parts[i]}' không phải số nguyên hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Lỗi phân tích dữ liệu: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy mảng hiện tại
        /// </summary>
        public int[] GetArray() => (int[])array.Clone();

        /// <summary>
        /// Lấy độ dài mảng
        /// </summary>
        public int Length => array.Length;

        /// <summary>
        /// Sắp xếp mảng tăng dần
        /// </summary>
        public int[] SortAscending()
        {
            int[] result = (int[])array.Clone();
            Array.Sort(result);
            array = result;
            return result;
        }

        /// <summary>
        /// Sắp xếp mảng giảm dần
        /// </summary>
        public int[] SortDescending()
        {
            int[] result = (int[])array.Clone();
            Array.Sort(result, (a, b) => b.CompareTo(a));
            array = result;
            return result;
        }

        /// <summary>
        /// Tìm vị trí của giá trị đầu tiên trong mảng
        /// </summary>
        public int SearchByValue(int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1; // Không tìm thấy
        }

        /// <summary>
        /// Tìm tất cả vị trí của một giá trị trong mảng
        /// </summary>
        public List<int> SearchAllPositions(int value)
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    positions.Add(i);
            }
            return positions;
        }

        /// <summary>
        /// Lấy giá trị tại vị trí chỉ định
        /// </summary>
        public int GetValueAtPosition(int position)
        {
            if (position < 0 || position >= array.Length)
                throw new IndexOutOfRangeException($"Vị trí {position} nằm ngoài phạm vi [0, {array.Length - 1}].");

            return array[position];
        }

        /// <summary>
        /// Thêm giá trị mới tại vị trí chỉ định
        /// </summary>
        public int[] InsertAtPosition(int value, int position)
        {
            if (position < 0 || position > array.Length)
                throw new IndexOutOfRangeException($"Vị trí {position} không hợp lệ. Phạm vi [0, {array.Length}].");

            int[] result = new int[array.Length + 1];

            // Copy các phần tử trước vị trí
            Array.Copy(array, 0, result, 0, position);

            // Thêm giá trị mới
            result[position] = value;

            // Copy các phần tử sau vị trí
            Array.Copy(array, position, result, position + 1, array.Length - position);

            array = result;
            return result;
        }

        /// <summary>
        /// Xóa phần tử tại vị trí chỉ định
        /// </summary>
        public int[] RemoveAtPosition(int position)
        {
            if (position < 0 || position >= array.Length)
                throw new IndexOutOfRangeException($"Vị trí {position} nằm ngoài phạm vi [0, {array.Length - 1}].");

            if (array.Length == 1)
                throw new InvalidOperationException("Không thể xóa phần tử cuối cùng từ mảng.");

            int[] result = new int[array.Length - 1];

            Array.Copy(array, 0, result, 0, position);
            Array.Copy(array, position + 1, result, position, array.Length - position - 1);

            array = result;
            return result;
        }

        /// <summary>
        /// Tính tổng tất cả phần tử trong mảng
        /// </summary>
        public long CalculateSum()
        {
            long sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        /// <summary>
        /// Tính tổng các số chẵn
        /// </summary>
        public long CalculateEvenSum()
        {
            long sum = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                    sum += num;
            }
            return sum;
        }

        /// <summary>
        /// Tính tổng các số lẻ
        /// </summary>
        public long CalculateOddSum()
        {
            long sum = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                    sum += num;
            }
            return sum;
        }

        /// <summary>
        /// Tìm giá trị lớn nhất trong mảng
        /// </summary>
        public int FindMax()
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Mảng rỗng.");

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Tìm giá trị nhỏ nhất trong mảng
        /// </summary>
        public int FindMin()
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Mảng rỗng.");

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        /// <summary>
        /// Thay thế giá trị tại vị trí chỉ định
        /// </summary>
        public void ReplaceAtPosition(int position, int newValue)
        {
            if (position < 0 || position >= array.Length)
                throw new IndexOutOfRangeException($"Vị trí {position} nằm ngoài phạm vi [0, {array.Length - 1}].");

            array[position] = newValue;
        }

        /// <summary>
        /// Thay thế tất cả các vị trí có giá trị tương ứng
        /// </summary>
        public int[] ReplaceValue(int oldValue, int newValue)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == oldValue)
                {
                    array[i] = newValue;
                    count++;
                }
            }

            if (count == 0)
                throw new InvalidOperationException($"Không tìm thấy giá trị {oldValue} trong mảng.");

            return array;
        }

        /// <summary>
        /// Đảo ngược mảng
        /// </summary>
        public int[] Reverse()
        {
            Array.Reverse(array);
            return array;
        }

        /// <summary>
        /// Lấy chuỗi đại diện của mảng
        /// </summary>
        public override string ToString()
        {
            return string.Join(" ", array);
        }

        /// <summary>
        /// Lấy chuỗi đại diện của mảng với định dạng tùy chỉnh
        /// </summary>
        public string ToString(string separator)
        {
            return string.Join(separator, array);
        }

        /// <summary>
        /// Kiểm tra xem mảng có chứa giá trị không
        /// </summary>
        public bool Contains(int value)
        {
            return SearchByValue(value) != -1;
        }

        /// <summary>
        /// Đếm số lần xuất hiện của một giá trị
        /// </summary>
        public int CountOccurrences(int value)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num == value)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Lấy thống kê mảng
        /// </summary>
        public ArrayStatistics GetStatistics()
        {
            return new ArrayStatistics
            {
                Length = array.Length,
                Sum = CalculateSum(),
                EvenSum = CalculateEvenSum(),
                OddSum = CalculateOddSum(),
                Max = FindMax(),
                Min = FindMin(),
                Average = (double)CalculateSum() / array.Length
            };
        }
    }

    /// <summary>
    /// Lớp chứa thông tin thống kê của mảng
    /// </summary>
    public class ArrayStatistics
    {
        public int Length { get; set; }
        public long Sum { get; set; }
        public long EvenSum { get; set; }
        public long OddSum { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public double Average { get; set; }
    }
}
