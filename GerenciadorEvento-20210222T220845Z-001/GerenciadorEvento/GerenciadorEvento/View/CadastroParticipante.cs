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
using GerenciadorEvento.TrataDados;
using GerenciadorEvento.Entidades;
using GerenciadorEvento.ConexaoMySQL;

namespace GerenciadorEvento.View
{
    public partial class CadastroParticipante : Form
    {
        TrataDadosParticipantes trataParticipante = new TrataDadosParticipantes();
        CriaConexao             criaConexao       = new CriaConexao();

        public CadastroParticipante()
        {
            InitializeComponent();
        }

        private void btnVoltarPart_Click(object sender, EventArgs e)
        {
            GerenciadorParticipantes gerenciadorParticipantes = new GerenciadorParticipantes();
            this.Hide();
            gerenciadorParticipantes.ShowDialog();
        }

        private void btnConcluirPart_Click(object sender, EventArgs e)
        {
            Participante participante = new Participante();

            participante.Nome      = textNomePart.Text;
            participante.SobreNome = textSobrenomePart.Text;

            if (trataParticipante.VerificaDados(participante))
            {
                if (criaConexao.CadastraParticipante(participante))
                    MessageBox.Show("Participante Cadastrado!");
                else
                    MessageBox.Show("Erro ao cadastrar participante!");
            }
            else
                MessageBox.Show("Nome ou Sobrenome inválido(s)");

            LimpaCampos();
        }

        private void LimpaCampos()
        {
            textNomePart.Text      = "";
            textSobrenomePart.Text = "";
        }
    }
}
