using CleanArchDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface IFinalEvaluation
    {
        public Task<FinalEvaluation> Adicionar();
    }
}
