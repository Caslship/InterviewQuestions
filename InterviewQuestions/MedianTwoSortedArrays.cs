using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class MedianTwoSortedArrays
    {
        public double FindMedian(List<int> a, List<int> b)
        {
            return FindMedian(a, b, 0, a.Count - 1, 0, b.Count - 1);
        }

        public double FindMedian(List<int> a, List<int> b, int aLo, int aHi, int bLo, int bHi)
        {
            var aLength = aHi - aLo + 1;
            var bLength = bHi - bLo + 1;

            if (aLength <= 0 || bLength <= 0)
            {
                if (aLength <= 0 && bLength <= 0)
                {
                    return 0.0;
                }

                if (aLength >= 1)
                {
                    return aLength % 2 == 0
                        ? (a[aLo + (aLength / 2)] + a[aLo + (aLength / 2) - 1]) / 2.0
                        : a[aLo + (aLength / 2)];
                }
                else if (bLength >= 1)
                {
                    return bLength % 2 == 0
                        ? (b[bLo + (bLength / 2)] + b[bLo + (bLength / 2) - 1]) / 2.0
                        : b[bLo + (bLength / 2)];
                }
            }

            if (aLength == 1 && bLength == 1)
            {
                return (a[aLo] + b[bLo]) / 2.0;
            }

            if (aLength == 2 && bLength == 1)
            {
                return Math.Min(
                    Math.Max(b[bLo], a[aLo]),
                    a[aHi]
                );
            }

            if (aLength == 1 && bLength == 2)
            {
                return Math.Min(
                    Math.Max(a[aLo], b[bLo]),
                    b[bHi]
                );
            }

            var aMedian = aLength % 2 == 0
                        ? (a[aLo + (aLength / 2)] + a[aLo + (aLength / 2) - 1]) / 2.0
                        : a[aLo + (aLength / 2)];
            var bMedian = bLength % 2 == 0
                        ? (b[bLo + (bLength / 2)] + b[bLo + (bLength / 2) - 1]) / 2.0
                        : b[bLo + (bLength / 2)];
            var aMedianIsLessThanBMedian = aMedian < bMedian;
            var minHalf = Math.Min((aLength + 1) / 2, (bLength + 1) / 2);

            return FindMedian(
                a,
                b,
                aMedianIsLessThanBMedian ? aLo + minHalf : aLo,
                !aMedianIsLessThanBMedian ? aHi - minHalf : aHi,
                !aMedianIsLessThanBMedian ? bLo + minHalf : bLo,
                aMedianIsLessThanBMedian ? bHi - minHalf : bHi
            );
        }
    }
}
