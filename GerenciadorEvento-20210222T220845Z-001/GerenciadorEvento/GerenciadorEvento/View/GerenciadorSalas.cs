using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEvento.View
{
    public partial class GerenciadorSalas : Form
    {
        public GerenciadorSalas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcluirSala excluirSala = new ExcluirSala();
            this.Hide();
            excluirSala.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telainicio TelaInicio = new telainicio();
            this.Hide();
            TelaInicio.ShowDialog();
        }

        private void btnCadastrarSala_Click(object sender, EventArgs e)
        {
            CadastroSalas cadastroSalas = new CadastroSalas(null);
            this.Hide();
            cadastroSalas.ShowDialog();
        }

        private void btnAlterarSala_Click(object sender, EventArgs e)
        {
            AlterarSala alterarSala = new AlterarSala();
            this.Hide();
            alterarSala.ShowDialog();
        }
    }
}
