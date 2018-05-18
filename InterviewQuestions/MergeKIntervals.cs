using InterviewQuestions.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class MergeKIntervals
    {
        public List<Interval> Merge(List<Interval> intervals)
        {
            var merged = new List<Interval>();

            if (intervals.Count == 0)
            {
                return merged;
            }

            merged.Add(
                new Interval
                {
                    Lo = intervals[0].Lo,
                    Hi = intervals[0].Hi
                }
            );

            foreach (var interval in intervals.Skip(1))
            {
                var minLo = merged[merged.Count - 1].Lo;
                var maxHi = merged[merged.Count - 1].Hi;

                if ((interval.Lo <= maxHi && interval.Lo >= minLo) ||
                    (interval.Hi <= maxHi && interval.Hi >= minLo))
                {
                    merged[merged.Count - 1].Lo = Math.Min(interval.Lo, minLo);
                    merged[merged.Count - 1].Hi = Math.Max(interval.Hi, maxHi);
                }
                else if ((interval.Lo <= minLo && interval.Hi >= minLo) ||
                    (interval.Hi >= maxHi && interval.Lo <= maxHi))
                {
                    merged[merged.Count - 1].Lo = Math.Min(interval.Lo, minLo);
                    merged[merged.Count - 1].Hi = Math.Max(interval.Hi, maxHi);
                }
                else
                {
                    merged.Add(interval);
                }
            }

            return merged;
        }
    }
}
