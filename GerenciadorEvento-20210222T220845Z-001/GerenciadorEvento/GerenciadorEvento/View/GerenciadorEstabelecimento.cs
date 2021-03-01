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
    public partial class GerenciadorEstabelecimento : Form
    {
        public GerenciadorEstabelecimento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroEstabelecimento cadastroEstabelecimento = new CadastroEstabelecimento();

            this.Hide();

            cadastroEstabelecimento.ShowDialog();
        }
   

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            telainicio telainicio = new telainicio();

            this.Hide();

            telainicio.ShowDialog();

        }

        private void btnExluirEstabe_Click(object sender, EventArgs e)
        {
            ExcluiEstabelecimentos excluiEstabelecimentos = new ExcluiEstabelecimentos();

            this.Hide();

            excluiEstabelecimentos.ShowDialog();
        }

        private void btnAlterarEstabe_Click(object sender, EventArgs e)
        {
            AlteraEstabelecimento allt = new AlteraEstabelecimento();

            this.Hide();

            allt.ShowDialog();
        }
    }
}
