using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibUA
{
    public static class ArraySegmentExtensions
    {
        public static T[] ToArray<T>(this ArraySegment<T> segment)
        {
            if (segment.Array == null)
                return new T[0];

            T[] arr = new T[segment.Count];
            Array.Copy(segment.Array, segment.Offset, arr, 0, segment.Count);
            return arr;
        }

        public static T Get<T>(this ArraySegment<T> segment, int index)
        {
            if (index < 0 || index >= segment.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            return segment.Array[segment.Offset + index];
        }
        
        public static void Set<T>(this ArraySegment<T> segment, int index, T value)
        {
            if (index < 0 || index >= segment.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            segment.Array[segment.Offset + index] = value;
        }

        public static ArraySegment<T> AsSegment<T>(this T[] array)
        {
            return new ArraySegment<T>(array);
        }
        
        public static ArraySegment<T> AsSegment<T>(this T[] array, int offset, int count)
        {
            return new ArraySegment<T>(array, offset, count);
        }
    }
}
