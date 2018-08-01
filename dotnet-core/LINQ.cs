using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_core
{
    public class LINQ
    {
        private readonly List<string> _items = Enumerable.Range(0, 50000).Select(i => "Num" + i).ToList();

        [Benchmark(Description = ".Count()")]
        public void Count()
        {
            var i = _items.Count();
        }

        [Benchmark(Description = "Property Count")]
        public void RawCount()
        {
            var i = _items.Count;
        }
    }
}
