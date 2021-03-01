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
using GerenciadorEvento.Controller;

namespace GerenciadorEvento
{
    public partial class telainicio : Form
    {

        public static GerenciadorParticipantes gereParticipantes = null;
        public static GerenciadorSalas gereSalas;
        public static GerenciadorEstabelecimento gereEstabelecimento = null;
        public static AtribuirSalaPart gereSalaPart = null;
        InicializaConexao initConnect = null;

        public static void _init()
        {
            gereParticipantes = new GerenciadorParticipantes();
            gereSalas = new GerenciadorSalas();
            gereEstabelecimento = new GerenciadorEstabelecimento();
            gereSalaPart = new AtribuirSalaPart();
        }

        public telainicio()
        {

            _init();

            InitializeComponent();

            initConnect = new InicializaConexao();
            initConnect.InicializaConexoes();
            
        }

        private void btnGerenPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            gereParticipantes.ShowDialog();
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            this.Hide();
            gereSalaPart.ShowDialog();
        }

        private void btnGerenSala_Click(object sender, EventArgs e)
        {
            this.Hide();
            gereSalas.ShowDialog();
        }

        private void btnGerenEstabe_Click(object sender, EventArgs e)
        {
            this.Hide();
            gereEstabelecimento.ShowDialog();
        }
    }
}
