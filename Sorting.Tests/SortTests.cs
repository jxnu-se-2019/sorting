using System.Collections.Generic;
using NUnit.Framework;
using Sorting.Core;
using System.Linq;
using System;
using Newtonsoft.Json;

namespace Sorting.Tests
{
    public class SortTests
    {

        private readonly List<SorterBase> _sorters;
        public SortTests()
        {
            var baseType = typeof(SorterBase);
            _sorters = baseType.Assembly.GetTypes()
                 .Where(x => x.IsSubclassOf(baseType))
                 .Select(x => Activator.CreateInstance(x) as SorterBase)
                 .ToList();
        }

        private List<int[]> _inputs = new List<int[]>();

        [SetUp]
        public void Setup()
        {
            var random = new Random();
            var length = random.Next(1, 5);
            for (var index = 0; index < length; index++)
            {
                var input = new int[random.Next(10, 20)];
                for(var subIndex = 0; subIndex < input.Length; subIndex ++)
                {
                    input[subIndex] = random.Next(1, 20);
                }
                _inputs.Add(input);
            }
        }

        [Test]
        public void TestAll()
        {
            Console.WriteLine($"{_sorters.Count} in total");
            foreach(var sorter in _sorters)
            {
                var typeName = sorter.GetType().FullName;
                Console.WriteLine($"Testing {typeName}: ");

               TestA_ThrowNullException(sorter);

                foreach(var input in _inputs)
                {
                    TestA_Sort(sorter, input);
                }
            }
        }

        private void TestA_ThrowNullException(SorterBase sorter)
        {
            try
            {
                sorter.Sort(null);
                Assert.IsNotEmpty("Should throw ArgumentNullException");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ArgumentNullException>(ex);
            }
        }

        private void TestA_Sort(SorterBase sorter, int[] input)
        {
            var expected = input.Clone() as int[];
            Array.Sort(expected);
            
            sorter.Sort(input);
            var inputString = JsonConvert.SerializeObject(input);
            Console.WriteLine($"input: {inputString}");

            var expectedString = JsonConvert.SerializeObject(expected);
            Console.WriteLine($"expected: {expectedString}");

            Assert.AreEqual(expectedString, inputString);
        }
    }
}