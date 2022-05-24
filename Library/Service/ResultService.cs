using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class ResultService
    {
        public BmiResult? RecentOverweightResult { get; private set; }
        private readonly ResultRepository _resultRepository;

        public ResultService()
        {
            _resultRepository = new ResultRepository();
        }

        public void SecRecentOverweightResult(BmiResult result)
        {
            if (result.BmiClassification == BmiClassification.Overweight)
            {
                RecentOverweightResult = result;
            }
        }

        public async Task SaveUnderweightResultAsync(BmiResult result)
        {
            if (result.BmiClassification == BmiClassification.Underweight)
            {
                await _resultRepository.SaveResultAsync(result);
            }
        }
    }
}
