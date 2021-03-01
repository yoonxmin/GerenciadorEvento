using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorEvento.Entidades;
using GerenciadorEvento.TrataDados;
using GerenciadorEvento.Controller;

namespace GerenciadorEvento.View
{
    public partial class AlteraEstabelecimento : Form
    {
        ControllerEstabelecimentos controllerEstabelecimento = new ControllerEstabelecimentos();
        TrataDadosEstabelecimento trataDadosEstabe = new TrataDadosEstabelecimento();
        List<Estabelecimento> listaEstabelecimento;

        public AlteraEstabelecimento()
        {
            InitializeComponent();

            PreencheComboBoxEstabelecimento();
        }

        private void PreencheComboBoxEstabelecimento()
        {
            listaEstabelecimento = controllerEstabelecimento.CarregaEstabelecimento();

            for (int indexEstabelecimentos = 0; indexEstabelecimentos < listaEstabelecimento.Count(); indexEstabelecimentos++)
            {
                Estabelecimento estabelecimento = listaEstabelecimento[indexEstabelecimentos];
                comboBoxEstabe.Items.Add(estabelecimento.NomeCafe + " " + estabelecimento.Lotacao);
            }

        }

        private void btnCancelaEstabe_Click(object sender, EventArgs e)
        {
            LimpaCampos1(); 
        }

        private void btnAlterarEstabe_Click(object sender, EventArgs e)
        {
            Estabelecimento estabelecimento = listaEstabelecimento[comboBoxEstabe.SelectedIndex];

            estabelecimento.NomeCafe = textNomeEstabe.Text;
            estabelecimento.Lotacao = Convert.ToInt32(textLotaEstabe);

            if (trataDadosEstabe.VerificaDados(listaEstabelecimento[comboBoxEstabe.SelectedIndex]))
            {
                if (controllerEstabelecimento.AlteraEstabelecimento(estabelecimento))
                    MessageBox.Show("Participante alterado com sucesso");
                else
                    MessageBox.Show("Erro ao alterar o Estabelecimento");
            }
            else
                MessageBox.Show("Nome ou lotação inválido(s)");

            LimpaCampos();
            PreencheComboBoxEstabelecimento();
        }

        private void LimpaCampos1()
        {
            textNomeEstabe.Text = "";
            textLotaEstabe.Text = "";
        }

        private void LimpaCampos()
        {
            textNomeEstabe.Text = "";
            textLotaEstabe.Text = "";

            comboBoxEstabe.SelectedIndex = -1;
            comboBoxEstabe.Items.Clear();
        }

        private void btnVoltarEstabe_Click(object sender, EventArgs e)
        {
            GerenciadorEstabelecimento gerenEstabelecimento = new GerenciadorEstabelecimento();
            this.Hide();
            gerenEstabelecimento.ShowDialog();
        }
    }
}
