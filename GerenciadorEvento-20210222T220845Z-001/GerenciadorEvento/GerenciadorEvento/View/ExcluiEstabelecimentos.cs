using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorEvento.Controller;
using GerenciadorEvento.Entidades;
using GerenciadorEvento.TrataDados;

namespace GerenciadorEvento.View
{
    public partial class ExcluiEstabelecimentos : Form
    {

        ControllerEstabelecimentos controllerEstabe = new ControllerEstabelecimentos();
        TrataDadosEstabelecimento trataDadosEstabe = new TrataDadosEstabelecimento();
        List<Estabelecimento> listaEstabe;

        public ExcluiEstabelecimentos()
        {
            InitializeComponent();
            PreencheComboBoxEstabelecimento();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PreencheComboBoxEstabelecimento()
        {
            listaEstabe = controllerEstabe.CarregaEstabelecimento();

            for (int indexEstabe = 0; indexEstabe < listaEstabe.Count(); indexEstabe++)
            {
                Estabelecimento estabe = listaEstabe[indexEstabe];
                comboBoxEstabe.Items.Add(estabe.NomeCafe + " " + estabe.Lotacao);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Estabelecimento estabe = listaEstabe[comboBoxEstabe.SelectedIndex];

                if (controllerEstabe.ExcluiEstabelecimento(estabe.IDEstabelecimento))
                    MessageBox.Show("Café removido com sucesso!");
                else
                    MessageBox.Show("Erro ao remover o Café!");

                LimpaCampos();
                PreencheComboBoxEstabelecimento();
            
        }

        private void LimpaCampos()
        {
            textNomeEstabe.Text = "";
            textLotaEstabe.Text = "";

            comboBoxEstabe.SelectedIndex = -1;
            comboBoxEstabe.Items.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorEstabelecimento GerenEstabe = new GerenciadorEstabelecimento();
            this.Hide();
            GerenEstabe.ShowDialog();
        }

        private void comboBoxEstabe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEstabe.SelectedIndex == -1)
                return;

            textNomeEstabe.Text = listaEstabe[comboBoxEstabe.SelectedIndex].NomeCafe;
            textLotaEstabe.Text = listaEstabe[comboBoxEstabe.SelectedIndex].Lotacao.ToString();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            LimpaCamposLim();
        }
        private void LimpaCamposLim()
        {
            textNomeEstabe.Text = "";
            textLotaEstabe.Text = "";
        }
    }

}

