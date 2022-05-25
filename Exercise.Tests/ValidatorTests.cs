using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Tests
{
    public class ValidatorTests
    {
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]
            {
                new List<DateRange>
                 {
                     new DateRange(new DateTime(2020, 1, 1), new DateTime(2020, 1, 15)),
                     new DateRange(new DateTime(2020, 2, 1), new DateTime(2020, 2, 15)),
                 },

                new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20))
            },
            new object[]
            {
                new List<DateRange>
                 {
                     new DateRange(new DateTime(2020, 1, 15), new DateTime(2020, 1, 25)),
                 },

                new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20))
            },
            new object[]
            {
                new List<DateRange>
                 {
                     new DateRange(new DateTime(2020, 1, 8), new DateTime(2020, 1, 25)),
                 },

                new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20))
            },
            new object[]
            {
                new List<DateRange>
                 {
                     new DateRange(new DateTime(2020, 1, 12), new DateTime(2020, 1, 14)),
                 },

                new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20))
            },
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void ValidateOverlapping_ForOverlappingDateRanges_ReturnsFalse(List<DateRange> ranges, DateRange input)
        {
            //arrange
            Validator validator = new Validator();

            //act

            bool result = validator.ValidateOverlapping(ranges, input);

            //assert

            result.Should().BeFalse();
        }


        //From course
        private List<List<DateRange>> _rangeList = new List<List<DateRange>>()
        {
            new List<DateRange>()
            {
                new DateRange(new DateTime(2020, 1, 1), new DateTime(2020, 1, 15)),
                new DateRange(new DateTime(2020, 2, 1), new DateTime(2020, 2, 15)),
            },
            new List<DateRange>()
            {
                new DateRange(new DateTime(2020, 1, 15), new DateTime(2020, 1, 25)),
            },
            new List<DateRange>()
            {
                new DateRange(new DateTime(2020, 1, 8), new DateTime(2020, 1, 25)),
            },
            new List<DateRange>()
            {
                new DateRange(new DateTime(2020, 1, 12), new DateTime(2020, 1, 14)),
            },
        };


        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void ValidateOverlapping_ForOverlappingDateRanges_ReturnsFalsev2(int index)
        {
            //arrange
            List<DateRange> ranges = _rangeList[index];
            DateRange input = new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20));
            Validator validator = new Validator();

            //act

            bool result = validator.ValidateOverlapping(ranges, input);

            //assert

            result.Should().BeFalse();
        }


        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        public void ValidateOverlapping_ForNonOverlappingDateRanges_ReturnsTruev2(int index)
        {
            //arrange
            List<DateRange> ranges = _rangeList[index];
            DateRange input = new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20));
            Validator validator = new Validator();

            //act

            bool result = validator.ValidateOverlapping(ranges, input);

            //assert

            result.Should().BeFalse();
        }
    }
}
