using SearchInsertPosition35;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSAlgo.Tests.SearchInsertPositionTest
{
    public class SearchInsertPositionTest
    {
        SearchInsertPosition _SearchInsertPosition;
        public SearchInsertPositionTest()
        {
            _SearchInsertPosition = new SearchInsertPosition();
        }

        [Fact]
        public void SearchInsert_ValidSearch_ReturnsIndex()
        {
            int test1 = _SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            int test2 = _SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            Assert.Equal(2, test1);
            Assert.Equal(1, test2);
        }
    }
}
