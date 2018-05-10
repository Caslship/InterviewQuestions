using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class EditStepLadder
    {
        public int ComputeMaxEditSteps(List<string> words)
        {
            var maxCost = 0;
            var wordCostMap = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordCostMap[word] = 1;
                maxCost = Math.Max(maxCost, 1);

                for (var i = 0; i < word.Length; ++i)
                {               
                    var wordBeforeIndex = word.Substring(0, i);
                    var wordUpToIndex = $"{wordBeforeIndex}{word[i]}";
                    var wordAfterIndex = i < word.Length - 1 ? word.Substring(i + 1) : string.Empty;
                    var removedLetterAtIndex = $"{wordBeforeIndex}{wordAfterIndex}";

                    if (removedLetterAtIndex.CompareTo(word) < 0 
                        && wordCostMap.TryGetValue(removedLetterAtIndex, out var removalCost))
                    {
                        wordCostMap[word] = Math.Max(wordCostMap[word], removalCost + 1);
                        maxCost = Math.Max(maxCost, removalCost + 1);
                    }

                    for (var letter = 'a'; letter <= 'z'; ++letter)
                    {
                        var addedLetterAfterIndex = $"{wordUpToIndex}{letter}{wordAfterIndex}";
                        var exchangedLetterAtIndex = $"{wordBeforeIndex}{letter}{wordAfterIndex}";

                        if (addedLetterAfterIndex.CompareTo(word) < 0
                            && wordCostMap.TryGetValue(addedLetterAfterIndex, out var additionCost))
                        {
                            wordCostMap[word] = Math.Max(wordCostMap[word], additionCost + 1);
                            maxCost = Math.Max(maxCost, additionCost + 1);
                        }

                        if (exchangedLetterAtIndex.CompareTo(word) < 0 
                            && wordCostMap.TryGetValue(exchangedLetterAtIndex, out var exchangeCost))
                        {
                            wordCostMap[word] = Math.Max(wordCostMap[word], exchangeCost + 1);
                            maxCost = Math.Max(maxCost, exchangeCost + 1);
                        }
                    }
                }
            }

            return maxCost;
        }
    }
}
