using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Tests
{
    public class ListHelperTests
    {
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new List<int> { 1, 2, 3}, new List<int> { 1, 3 } },
            new object[] { new List<int> { 1, 1, 2, 3, 3 }, new List<int> { 1, 1, 3, 3 } },
            new object[] { new List<int> { 8, 10 }, new List<int> {} },
            new object[] { new List<int> { 1, 2, 2, 3, 5, 7, 9, 8, 2 }, new List<int> { 1, 3, 5, 7, 9 } },
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void FilterOddNumber_ForIntLists_ReturnsOnlyOddNumbers(List<int> inputlist, List<int> correctList)
        {
            //arrange
            //var inputlist = new List<int>() { 1, 2, 2, 3, 5, 7, 9, 8, 2 };
            //var correctList = new List<int>() { 1, 3, 5, 7, 9 };

            //act
            var result = ListHelper.FilterOddNumber(inputlist);

            //assert

            result.Should().Equal(correctList);
        }
    }
}
