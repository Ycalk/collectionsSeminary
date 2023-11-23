using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsSeminary
{
    static class Task4
    {
        public static int Solution(int[] array, int sequenceLength)
        {
            var sum = 0;
            for (var i = 0; i < sequenceLength; i++)
            {
                sum += array[i];
            }

            var ans = sum;
            for (var i = sequenceLength; i+1 < array.Length; i++)
            {
                sum += array[i] - array[i - sequenceLength];
                ans = Math.Max(ans, sum);
            }

            return ans;
        }
    }
}
