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
    public partial class ExcluirSala : Form
    {
        ControllerSala controllersala = new ControllerSala();
        TrataDadosSala trataDadosSala = new TrataDadosSala();
        List<Sala> listaSala;

        public ExcluirSala()
        {
            InitializeComponent();
            PreencheComboBoxSala();
        }

        private void PreencheComboBoxSala()
        {
            listaSala = controllersala.CarregaSala();

            for (int indexSala = 0; indexSala < listaSala.Count(); indexSala++)
            {
                Sala sala = listaSala[indexSala];
                comboBoxSala.Items.Add(sala.NomeSala + " " + sala.Lotacao);
            }

        }

        private void btnExcluirSala_Click(object sender, EventArgs e)
        {
            Sala salas = listaSala[comboBoxSala.SelectedIndex];

            if (controllersala.ExluiSala(salas.IDSala))
                MessageBox.Show("Sala removida com sucesso!");
            else
                MessageBox.Show("Erro ao remover a sala!");

            LimpaCampos();
            PreencheComboBoxSala();
        }

        private void LimpaCampos()
        {
            textNomeSala.Text = "";
            textLotaSala.Text = "";

            comboBoxSala.SelectedIndex = -1;
            comboBoxSala.Items.Clear();
        }

        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSala.SelectedIndex == -1)
                return;

            this.textNomeSala.Text = listaSala[comboBoxSala.SelectedIndex].NomeSala;
            this.textLotaSala.Text = listaSala[comboBoxSala.SelectedIndex].Lotacao.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorSalas GerenSala = new GerenciadorSalas();
            this.Hide();
            GerenSala.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCamposLim();
        }

        private void LimpaCamposLim()
        {
            textNomeSala.Text = "";
            textLotaSala.Text = "";
        }

        private void comboBoxSala_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
