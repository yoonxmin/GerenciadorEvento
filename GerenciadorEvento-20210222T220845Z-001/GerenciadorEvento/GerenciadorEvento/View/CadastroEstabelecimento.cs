using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorEvento.TrataDados;
using GerenciadorEvento.Entidades;
using GerenciadorEvento.ConexaoMySQL;

namespace GerenciadorEvento.View
{
    public partial class CadastroEstabelecimento : Form
    {
        TrataDadosEstabelecimento trataEstabelecimento = new TrataDadosEstabelecimento();
        CriaConexao criaConexao = new CriaConexao();

        public CadastroEstabelecimento()
        {
            InitializeComponent();
        }

        private void textNomeCafe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarCafe_Click(object sender, EventArgs e)
        {

            GerenciadorEstabelecimento gerenEstabe = new GerenciadorEstabelecimento();
            this.Hide();
            gerenEstabe.ShowDialog();

        }

        private void btnConcluirCafe_Click(object sender, EventArgs e)
        {
            Estabelecimento estabelecimentos = new Estabelecimento();

            estabelecimentos.NomeCafe = textNomeCafe.Text;
            estabelecimentos.Lotacao = Convert.ToInt32(textLotaCafe.Text);

            if (trataEstabelecimento.VerificaDados(estabelecimentos))
            {
                if (criaConexao.CadastraEstabelecimento(estabelecimentos))
                    MessageBox.Show("Participante Cadastrado!");
                else
                    MessageBox.Show("Erro ao cadastrar participante!");
            }
            else
                MessageBox.Show("Nome ou Sobrenome inválido(s)");

            LimpaCampos();
        }

        private void LimpaCampos()
        {
            textNomeCafe.Text = "";
            textLotaCafe.Text = "";
        }

    } 
}
    
