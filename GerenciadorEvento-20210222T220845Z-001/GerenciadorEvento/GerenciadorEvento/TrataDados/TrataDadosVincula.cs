using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEvento.TrataDados
{
    class TrataDadosVincula
    {
        public Boolean TrataDadosVinc(int idParticipante, int idSalaEvento , int idEstabelecimento)
        {

            if (idSalaEvento >= 1 && idParticipante >= 1)
                return true;

            return false;

            if (idEstabelecimento > 0)           
                return true;

            return false;            
        }
    }
}
