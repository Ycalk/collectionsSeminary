
namespace collectionsSeminary
{
    internal class Task1
    {
        private readonly int[] _processedArray;

        public Task1(int[] mas)
        {
            _processedArray = MakePreprocessing(mas);
        }

        private static int[] MakePreprocessing(int[] original)
        {
            var result = new int[original.Length];
            var sum = 0;
            for (var i = 0; i < original.Length; i++)
            {
                result[i] = sum;
                sum += original[i];
            }

            return result;
        }
        
        public int GetSumOnInterval(int l, int r)
        {
            return _processedArray[r+1] - _processedArray[l];
        }
    }
}
