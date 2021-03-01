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
    public partial class CadastroSalas : Form
    {

        TrataDadosSala trataSala = new TrataDadosSala();
        CriaConexao criaConexao = new CriaConexao();

        public CadastroSalas(Object[] obj)
        {
            if (obj == null)
            {
                InitializeComponent();
            }
        }



        private void textNomePart_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConcluirSala_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala();

            sala.NomeSala = textNomeSala.Text;

            sala.Lotacao = Convert.ToInt32(textLotaSala.Text);

            if (trataSala.VerificaDados(sala))
            {
                if (criaConexao.CadastraSala(sala))
                    MessageBox.Show("Sala Cadastrada!");
                else
                    MessageBox.Show("Erro ao cadastrar Sala!");
            }
            else
                MessageBox.Show("Nome ou Lotação inválido(s)");

            LimpaCampos();
        }
        private void LimpaCampos()
        {
            textNomeSala.Text = "";
            textLotaSala.Text = "";
        }

        private void btnCancelarSala_MouseClick(object sender, MouseEventArgs e)
        {
            _Cancel_enter();
        }

        private void btnCancelarSala_Click(object sender, EventArgs e)
        {
            _Cancel_enter();
        }

        void _Cancel_enter()
        {
            telainicio telaInicio = new telainicio();
            this.Hide();
            telaInicio.ShowDialog();
        }
    }
}
