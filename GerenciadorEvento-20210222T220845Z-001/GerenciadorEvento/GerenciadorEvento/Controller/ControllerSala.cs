using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorEvento.Entidades;
using GerenciadorEvento.ConexaoMySQL;

namespace GerenciadorEvento.Controller
{
    class ControllerSala
    {
        CriaConexao conexaoMySQL = new CriaConexao();
        public bool CadastraSala(Sala salas)
        {

            if (conexaoMySQL.CadastraSala(salas))
                return true;

            return false;
        }

        public List<Sala> CarregaSala()
        {
            return conexaoMySQL.CarregaTodasSalas();
        }

        public bool AlteraSala(Sala salas)
        {
            return conexaoMySQL.AlteraSala(salas);
        }

        public bool ExluiSala(int IDSala)
        {
            return conexaoMySQL.ExcluiSala(IDSala);
        }

    }
}
