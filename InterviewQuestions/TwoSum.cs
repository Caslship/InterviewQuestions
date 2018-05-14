using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class TwoSum
    {
        public bool ExistsPairEqualToSum(int sum, List<int> values)
        {
            if (values == null || values.Count == 0)
            {
                throw new ArgumentException();
            }

            var existingNumbers = new HashSet<int>();

            foreach (var value in values)
            {
                if (existingNumbers.Contains(sum - value))
                {
                    return true;
                }

                existingNumbers.Add(value);
            }

            return false;
        }
    }
}
