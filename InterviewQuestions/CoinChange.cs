using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class CoinChange
    {
        public List<int> DefaultCoins { get; } = new List<int>
        {
            1,
            5,
            10,
            25
        };

        public int ComputeMinChangeCount(int amount)
        {
            return ComputeMinChangeCount(amount, DefaultCoins);
        }

        public int ComputeMinChangeCount(int amount, List<int> coins)
        {
            var minChange = new List<int>
            {
                0,
            };

            for (var i = 1; i <= amount; ++i)
            {
                minChange.Add(int.MaxValue);

                foreach (var coin in coins)
                {
                    if (i - coin >= 0)
                    {
                        minChange[i] = Math.Min(1 + minChange[i - coin], minChange[i]);
                    }
                }
            }

            return minChange[amount];
        }

        public int ComputeChangePermutationsCount(int amount)
        {
            return ComputeChangePermutationsCount(amount, DefaultCoins);
        }

        public int ComputeChangePermutationsCount(int amount, List<int> coins)
        {
            var changePermutations = Enumerable.Repeat(0, amount + 1).ToList();
            changePermutations[0] = 1;

            foreach (var coin in coins)
            {
                for (var i = coin; i <= amount; ++i)
                {
                    changePermutations[i] += changePermutations[i - coin];
                }
            }

            return changePermutations[amount];
        }
    }
}
