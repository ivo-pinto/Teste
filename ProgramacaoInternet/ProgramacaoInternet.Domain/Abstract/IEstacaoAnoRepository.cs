using ProgramacaoInternet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoInternet.Domain.Abstract
{
    //public ???
    public interface IEstacaoAnoRepository
    {
        IEnumerable<EstacaoAno> EstacoesAno { get; }
    }
}
