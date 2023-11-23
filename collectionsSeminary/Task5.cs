using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsSeminary
{
    static class Task5
    {
        // Допустим если есть массив [20, 1, 30, 40] и [1, 50, 60, 70]. Если у первого массива отбросить все 
        // элементы, кроме "1", тогда в нем будет подпоследовательность длиной 1 и состоящая из "1" и во втором массиве 
        // будет подпоследовательность длиной 1 и состоящая из "1"


        public static bool Solution(int[] mas1, int[] mas2)
        {
            foreach (var el in mas1)
            {
                if (mas2.Contains(el))
                    return true;
            }

            return false;
        }
    }
}
