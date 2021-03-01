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
    public partial class AlterarSala : Form
    {
        ControllerSala controllerSalas = new ControllerSala();
        TrataDadosSala trataDadosSalas = new TrataDadosSala();
        List<Sala> listaSala;
        public AlterarSala()
        {
            InitializeComponent();
            PreencheComboBoxSala();
        }

        private void PreencheComboBoxSala()
        {
            listaSala = controllerSalas.CarregaSala();

            for (int indexSala = 0; indexSala < listaSala.Count(); indexSala++)
            {
                Sala salas = listaSala[indexSala];
                comboBoxSala.Items.Add(salas.NomeSala + " " + salas.Lotacao);
            }

        }

        private void btnAlteraSala_Click(object sender, EventArgs e)
        {

            Sala salas = listaSala[comboBoxSala.SelectedIndex];

            salas.NomeSala = textNomeSala.Text;
            salas.Lotacao = Convert.ToInt32(textLotaSala.Text);

            if (trataDadosSalas.VerificaDados(listaSala[comboBoxSala.SelectedIndex]))
            {
                if (controllerSalas.AlteraSala(salas))
                    MessageBox.Show("Sala alterada com sucesso");
                else
                    MessageBox.Show("Erro ao alterar a sala");
            }
            else
                MessageBox.Show("Nome ou Lotação inválido(s)");

            LimpaCampos();
            PreencheComboBoxSala();

        }

        private void comboBoxPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            textNomeSala.Enabled = true;
            textLotaSala.Enabled = true;
        }

        private void LimpaCampos()
        {
            textNomeSala.Text = "";
            textLotaSala.Text = "";

            comboBoxSala.SelectedIndex = -1;
            comboBoxSala.Items.Clear();
        }

        private void LimpaCamposLim()
        {
            textNomeSala.Text = "";
            textLotaSala.Text = "";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {

            LimpaCamposLim();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorSalas GerenSalas = new GerenciadorSalas();
            this.Hide();
            GerenSalas.ShowDialog();
        }

        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNomeSala_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
