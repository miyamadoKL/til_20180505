using System;

namespace til_20180505
{
    public static class ExtentionSample
    {
        public static bool IsBiggerThan<T> (this T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0;
        }
        public static bool IsEqual<T> (this T a, T b) where T : IEquatable<T>
        {
            return a.Equals(b);
        }
        public static bool IsSmallerThan<T> (this T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) < 0;
        }
        public static bool IsInBetween<T> (this T value, T min, T max) where T: IComparable<T>
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var x = 100.5;
            var y = 111.2;
            var z = 108.9;
            Console.WriteLine(x.IsBiggerThan(y));
            Console.WriteLine(x.IsEqual(y));
            Console.WriteLine(x.IsSmallerThan(y));
            Console.WriteLine(z.IsInBetween(x, y));
        }
    }
}
