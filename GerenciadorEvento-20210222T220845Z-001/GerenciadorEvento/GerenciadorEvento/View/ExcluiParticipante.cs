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
    public partial class ExcluiParticipante : Form
    {
        ControllerParticipantes controllerParticipantes = new ControllerParticipantes();
        TrataDadosParticipantes trataDadosParticipantes = new TrataDadosParticipantes();
        List<Participante> listaParticipantes;

        public ExcluiParticipante()
        {
            InitializeComponent();
            PreencheComboBoxParticipantes();
        }

        private void PreencheComboBoxParticipantes()
        {
            listaParticipantes = controllerParticipantes.CarregaParticipantes();

            for (int indexParticipante = 0; indexParticipante < listaParticipantes.Count(); indexParticipante++)
            {
                Participante participante = listaParticipantes[indexParticipante];
                comboBoxPart.Items.Add(participante.Nome + " " + participante.SobreNome);
            }

        }

        private void btnExcluirPart_Click(object sender, EventArgs e)
        {
            Participante participante = listaParticipantes[comboBoxPart.SelectedIndex];

            if (controllerParticipantes.ExcluiParticipante(participante.IDParticipante))
                MessageBox.Show("Participante removido com sucesso!");
            else
                MessageBox.Show("Erro ao remover o participante!");

            LimpaCampos();
            PreencheComboBoxParticipantes();
        }

        private void LimpaCampos()
        {
            textNomePart.Text = "";
            textSobrenomePart.Text = "";

            comboBoxPart.SelectedIndex = -1;
            comboBoxPart.Items.Clear();
        }

        private void comboBoxPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPart.SelectedIndex == -1)
                return;

            textNomePart.Text = listaParticipantes[comboBoxPart.SelectedIndex].Nome;
            textSobrenomePart.Text = listaParticipantes[comboBoxPart.SelectedIndex].SobreNome;
        }

        private void btnVoltarPart_Click(object sender, EventArgs e)
        {
            GerenciadorParticipantes GerenPart = new GerenciadorParticipantes();
            this.Hide();
            GerenPart.ShowDialog();
        }
    }
}
