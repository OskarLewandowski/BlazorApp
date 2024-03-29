﻿using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public interface IResultRepository
    {
        Task SaveResultAsync(BmiResult result);
    }

    public class ResultRepository : IResultRepository
    {
        public Task SaveResultAsync(BmiResult result)
        {
            return Task.CompletedTask;
        }
    }
}
