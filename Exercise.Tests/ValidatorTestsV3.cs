using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Tests
{
    public class ValidatorTestsV3
    {
        [Theory]
        [ClassData(typeof(ValidatorTestsData))]
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
