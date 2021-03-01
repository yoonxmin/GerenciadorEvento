using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorEvento.ConexaoMySQL;

namespace GerenciadorEvento.Controller
{
    class InicializaConexao
    {
        CriaConexao conexao = new CriaConexao();
        public void InicializaConexoes()
        {
            conexao.CriaDataBase();
            conexao.CriaTabelaParticipante();
            conexao.CriaTabelaEstabelecimento();
            conexao.CriaTabelaSala();
        }
    }
}
