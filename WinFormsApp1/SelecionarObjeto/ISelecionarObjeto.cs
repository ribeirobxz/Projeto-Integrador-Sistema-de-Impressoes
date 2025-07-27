using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SelecionarObjeto
{
    internal interface ISelecionarObjeto
    {
        string ObterTituloDoForm();
        string ObterTextoInformativoDoForm();
        object[] ObterConteudoPesquisado(string OqueProcurar);
        Action<object> RetornarObjetoEscolhido();
    }
}
