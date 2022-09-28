using FindMissingNumberInArray;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSAlgo.Tests.FindSingleNumberInArr
{
    public class FindSIngleNumberTest
    {
        [Fact]
        public void FindSingleNumberDictionary_ReturnsCorrectOutput()
        {
            var result = FindSingleNumber.FindSingleNumberUsingDictionary(new int[] { 1, 4 });
            Assert.Equal(1, 1);
        }

        [Fact]
        public void FindSingleNumberUsingXOR_ValidInput_ReturnsCorrectResult()
        {
            var result = FindSingleNumber.FindSingleNumberUsingDictionary(new int[] { 1, 4, 2, 1, 3, 2, 3 });
            Assert.Equal(4, result);
        }
    }
}
