using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorEvento.View;

namespace GerenciadorEvento.View
{
    public partial class GerenciadorParticipantes : Form
    {
        public GerenciadorParticipantes()
        {
            InitializeComponent();
        }

        private void btnCadastrarPart_Click(object sender, EventArgs e)
        {
            CadastroParticipante cadastroParticipante = new CadastroParticipante();

            this.Hide();

            cadastroParticipante.ShowDialog();
        }

        private void btnAlterarPart_Click(object sender, EventArgs e)
        {
            AlterarParticipante alteraParticipante = new AlterarParticipante();

            this.Hide();

            alteraParticipante.ShowDialog();
        }

        private void btnExcluirPart_Click(object sender, EventArgs e)
        {
            ExcluiParticipante excluiParticipate = new ExcluiParticipante();

            this.Hide();

            excluiParticipate.ShowDialog();
        }

        private void VoltarPart_Click(object sender, EventArgs e)
        {

            telainicio telaInicio = new telainicio();
            this.Hide();
            telaInicio.ShowDialog();
        }
    }
}
