using System;
using System.Collections.Generic;
using System.Linq;



namespace collectionsSeminary
{
    internal class Task2
    {
        private readonly List<Dictionary<int[], int>> _segmentTree;
        private readonly int _originalArrayLength;

        public Task2(int arrayLength)
        {
            _originalArrayLength = arrayLength;
            _segmentTree = new List<Dictionary<int[], int>>
            {
                new()
                {
                    {new []{1, arrayLength}, 0}
                }
            };

            CreateSegmentTree();
        }

        private void CreateSegmentTree()
        {
            for (var i = 1; !EndOfTree(_segmentTree.Last()); i++)
            {
                _segmentTree.Add(new Dictionary<int[], int>());
                CreateLevel(i);
            }
        }

        private static bool EndOfTree(Dictionary<int[], int> dictionary)
        {
            foreach (var key in dictionary.Keys)
                if (key[0] != key[1])
                    return false;

            return true;
        }

        private void CreateLevel(int i)
        {
            foreach (var segment in _segmentTree[i - 1].Keys)
            {
                var segmentLength = (segment[1] - segment[0] + 1) / 2;

                var firstKey = new[]
                {
                    segment[0], segment[0] + segmentLength - 1
                };

                var secondKey = new[]
                {
                    segment[0] + segmentLength, segment[1]
                };
                

                if (firstKey[0] <= firstKey[1]  && secondKey[0] <= secondKey[1])
                {
                    _segmentTree[i][firstKey] = 0;
                    _segmentTree[i][secondKey] = 0;
                }
            }
        }

        private static bool SumRepresented(int[] segment)
        {
            foreach (var ind in segment)
                if (ind != -1)
                    return false;
            return true;
        }

        private static void MarkAsSummed(int[] request, int start, int end)
        {
            for (var i = start - 1; i < end; i++)
                request[i] = -1;
        }

        private int[] CreateRequestArray(int L, int R, int X)
        {
            var request = new int[_originalArrayLength];
            for (var i = 0; i < request.Length; i++)
            {
                if (L <= i + 1 && i + 1 <= R)
                {
                    request[i] = i + 1;
                }
                else
                {
                    request[i] = -1;
                }
            }

            return request;
        }

        public void CreateRequest(int L, int R, int X)
        {
            var request = CreateRequestArray(L, R, X);

            for (var level = 0; !SumRepresented(request); level++) 
                foreach (var segment in _segmentTree[level].Keys)
                {
                    if (request.Contains(segment[0]) && request.Contains(segment[1]))
                    {
                        _segmentTree[level][segment] += X;
                        MarkAsSummed(request, segment[0], segment[1]);
                    }
                }
            
        }

        public void PrintArray()
        {
            var array = new int[_originalArrayLength];

            foreach (var level in _segmentTree)
            foreach (var key in level.Keys)
            {
                var convertedSegment = Enumerable.Range(key[0], key[1] - key[0] + 1).ToArray();
                foreach (var ind in convertedSegment)
                {
                    array[ind - 1] += level[key];
                }
            }

            foreach (var el in array)
                Console.Write(el + " ");
        }
    }
}
