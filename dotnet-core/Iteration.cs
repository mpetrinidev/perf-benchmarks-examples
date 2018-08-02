using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_core
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
    public class Iteration
    {
        private readonly List<int> _elements = Enumerable.Range(0, 35000).ToList();

        [Benchmark(Description = ".Count()")]
        public int Count()
        {
            return _elements.Count();
        }

        [Benchmark(Description = "Raw Count")]
        public int RawCount()
        {
            return _elements.Count;
        }

        [Benchmark(Description = ".ForEach()")]
        public int OwnCount()
        {
            var i = 0;
            _elements.ForEach(e => i++);

            return i;
        }

        [Benchmark(Description = "foreach")]
        public int OwnCountB()
        {
            var i = 0;
            foreach (var e in _elements)
                i++;

            return i;
        }

        [Benchmark(Description = "for(;;)")]
        public int OwnCountC()
        {
            var e = 0;
            for (int i = 0; i < _elements.Count; i++)
                e++;

            return e;
        }

        //[Benchmark(Description = ".Any()")]
        //public bool Any()
        //{
        //    return _elements.Any();
        //}

        //[Benchmark(Description = "Raw Any")]
        //public bool RawAny()
        //{
        //    foreach (var i in _elements)
        //        return true;

        //    return false;
        //}
    }
}
