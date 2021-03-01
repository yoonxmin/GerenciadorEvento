using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorEvento.Entidades;

namespace GerenciadorEvento.TrataDados
{
    class TrataDadosEstabelecimento
    {

        public bool VerificaDados(Estabelecimento estabelecimentos)
        {
            if (estabelecimentos.NomeCafe.Trim().Equals("") || estabelecimentos.Lotacao.Equals(""))
                return false;

            return true;
        }

    }
}
