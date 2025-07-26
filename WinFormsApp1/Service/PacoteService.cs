using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Context;

namespace WinFormsApp1.Service
{
    internal class PacoteService
    {
        private readonly PacoteRepository _pacoteRepository;

        public PacoteService(PacoteRepository pacoteRepository)
        {
            _pacoteRepository = pacoteRepository;
        }

    }
}
