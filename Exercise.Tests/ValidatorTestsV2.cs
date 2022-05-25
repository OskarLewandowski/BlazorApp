using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Tests
{
    public class ValidatorTestsV2
    {
        private static IEnumerable<object[]> GetRangeList()
        {
            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 1), new DateTime(2020, 1, 15)),
                    new DateRange(new DateTime(2020, 2, 1), new DateTime(2020, 2, 15)),
                }
            };
            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 15), new DateTime(2020, 1, 25)),
                }
            };
            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 8), new DateTime(2020, 1, 25)),
                }
            };
            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 12), new DateTime(2020, 1, 14)),
                }
            };
        }

        [Theory]
        [MemberData(nameof(GetRangeList))]
        public void ValidateOverlapping_ForOverlappingDateRanges_ReturnsFalsev2(List<DateRange> ranges)
        {
            //arrange
            DateRange input = new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20));
            Validator validator = new Validator();

            //act

            bool result = validator.ValidateOverlapping(ranges, input);

            //assert

            result.Should().BeFalse();
        }
    }
}
