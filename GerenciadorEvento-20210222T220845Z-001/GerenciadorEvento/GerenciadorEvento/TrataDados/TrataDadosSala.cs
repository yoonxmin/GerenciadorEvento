using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorEvento.Entidades;


namespace GerenciadorEvento.TrataDados
{
    class TrataDadosSala
    {

        public bool VerificaDados(Sala sala)
        {
            
            if ( (sala.NomeSala.Trim().Equals("") || sala.Lotacao.Equals("")))

                return false;

            return true;
        }


    }
}
