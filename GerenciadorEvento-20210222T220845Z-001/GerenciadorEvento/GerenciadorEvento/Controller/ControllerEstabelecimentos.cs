using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorEvento.Entidades;
using GerenciadorEvento.ConexaoMySQL;

namespace GerenciadorEvento.Controller
{
    class ControllerEstabelecimentos
    {

        CriaConexao conexaoMySQL = new CriaConexao();
        public bool CadastraEstabelecimento(Estabelecimento estabe)
        {

            if (conexaoMySQL.CadastraEstabelecimento(estabe))
                return true;

            return false;
        }

        public List<Estabelecimento> CarregaEstabelecimento()
        {
            return conexaoMySQL.CarregaTodosEstabelecimentos();
        }

        public bool AlteraEstabelecimento(Estabelecimento estabe)
        {
            return conexaoMySQL.AlteraEstabelecimento(estabe);
        }

        public bool ExcluiEstabelecimento(int IDEstabelecimento)
        {
            return conexaoMySQL.ExcluiEstabelecimento(IDEstabelecimento);
        }
    }
}
