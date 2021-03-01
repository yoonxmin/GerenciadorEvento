using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorEvento.Entidades;
using GerenciadorEvento.ConexaoMySQL;

namespace GerenciadorEvento.Controller
{
    class ControllerParticipantes
    {
        CriaConexao conexaoMySQL = new CriaConexao();
        public bool CadastraParticipante(Participante participante)
        {

            if (conexaoMySQL.CadastraParticipante(participante))
                return true;

            return false;
        }

        public List<Participante> CarregaParticipantes()
        {
            return conexaoMySQL.CarregaTodosParticipantes();
        }

        public bool AlteraParticipante(Participante participante)
        {
            return conexaoMySQL.AlteraParticipante(participante);
        }

        public bool ExcluiParticipante (int IDParticipante)
        {
            return conexaoMySQL.ExcluiParticipante(IDParticipante);
        }
    }
}
