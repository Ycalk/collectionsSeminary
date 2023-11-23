using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsSeminary
{
    static class Task3
    {
        public static int Solution(int[] array)
        {
            var sum = 0;
            var ans = array.Min();

            foreach (var el in array)
            {
                sum = Math.Max(el, sum + el);
                ans = Math.Max(ans, sum);
            }

            return ans;
        }
    }
}
