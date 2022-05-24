using Library.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    public class ResultServiceTests
    {
        [Fact()]
        public void SecRecentOverweightResult_ForOverweightResult_UpdatesProperty()
        {
            //arrange
            var result = new BmiResult { BmiClassification = BmiClassification.Overweight };
            //                                   we can use Moq to mock this
            var resultService = new ResultService(new ResultRepository());

            //act
            resultService.SecRecentOverweightResult(result);

            //assert
            resultService.RecentOverweightResult.Should().Be(result);

        }

        [Fact()]
        public void SecRecentOverweightResult_ForOverweightResult_DoesntUpdatesProperty()
        {
            //arrange
            var result = new BmiResult { BmiClassification = BmiClassification.Obesity };
            var resultService = new ResultService(new ResultRepository());

            //act
            resultService.SecRecentOverweightResult(result);

            //assert
            resultService.RecentOverweightResult.Should().BeNull();
        }

        [Fact]
        public async Task SaveUnderweightResultAsync_ForUnderweightResult_InvokesSaveResultAsync()
        {
            //arrange
            var result = new BmiResult { BmiClassification = BmiClassification.Underweight };
            var repoMock = new Mock<IResultRepository>();

            var resultService = new ResultService(repoMock.Object);

            //act
            await resultService.SaveUnderweightResultAsync(result);

            //assert                                             Times.Exactly(34)
            repoMock.Verify(mock => mock.SaveResultAsync(result), Times.Once);
        }

        [Fact]
        public async Task SaveUnderweightResultAsync_ForNonUnderweightResult_DoesntInvokeSaveResultAsync()
        {
            //arrange
            var result = new BmiResult { BmiClassification = BmiClassification.Normal };
            var repoMock = new Mock<IResultRepository>();

            var resultService = new ResultService(repoMock.Object);

            //act
            await resultService.SaveUnderweightResultAsync(result);

            //assert                                             Times.Exactly(34)
            repoMock.Verify(mock => mock.SaveResultAsync(result), Times.Never);
        }
    }
}
