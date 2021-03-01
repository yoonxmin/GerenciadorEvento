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
    public partial class AlterarParticipante : Form
    {
        ControllerParticipantes controllerParticipantes = new ControllerParticipantes();
        TrataDadosParticipantes trataDadosParticipantes = new TrataDadosParticipantes();
        List<Participante> listaParticipantes;

        public AlterarParticipante()
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

        private void btnAlterarPart_Click(object sender, EventArgs e)
        {
            Participante participante = listaParticipantes[comboBoxPart.SelectedIndex];
            
            participante.Nome = textNomePart.Text;
            participante.SobreNome = textSobrenomePart.Text;

            if (trataDadosParticipantes.VerificaDados(listaParticipantes[comboBoxPart.SelectedIndex]))
            {
                if (controllerParticipantes.AlteraParticipante(participante))                
                    MessageBox.Show("Participante alterado com sucesso");
                else
                    MessageBox.Show("Erro ao alterar o participante");
            }
            else
                MessageBox.Show("Nome ou sobrenome inválido(s)");

            LimpaCampos();
            PreencheComboBoxParticipantes();
        }

        private void comboBoxPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            textNomePart.Enabled = true;
            textSobrenomePart.Enabled = true;
        }

        private void LimpaCampos()
        {
            textNomePart.Text = "";
            textSobrenomePart.Text = "";

            comboBoxPart.SelectedIndex = -1;
            comboBoxPart.Items.Clear();
        }

        private void LimpaCamposLim()
        {
            textNomePart.Text = "";
            textSobrenomePart.Text = "";

        }

        private void btnVoltarPart_Click(object sender, EventArgs e)
        {
            GerenciadorParticipantes GerenPart = new GerenciadorParticipantes();
            this.Hide();
            GerenPart.ShowDialog();
        }

        private void btnConcluirPart_Click(object sender, EventArgs e)
        {
            LimpaCamposLim();
        }
    }
}
