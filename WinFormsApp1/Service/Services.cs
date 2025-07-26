using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Context;

namespace WinFormsApp1.Service
{
    internal class Services
    {
        public Services(RepositoryContext repositoryContext) 
        {
            AlunoService = new AlunoService(repositoryContext.AlunoRepository);
            PacoteService = new PacoteService(repositoryContext.PacoteRepository);
        }

        public AlunoService AlunoService { get; private init; }
        public PacoteService PacoteService { get; private init; }

        // colocar os outros Services aqui
    }
}
