using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorEvento.Entidades;

namespace GerenciadorEvento.TrataDados
{
    class TrataDadosParticipantes
    {
        public bool VerificaDados(Participante participante)
        {
            if (participante.Nome.Trim().Equals("") || participante.SobreNome.Trim().Equals(""))
                return false;

            return true;
        }
    }
}
