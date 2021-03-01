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
using GerenciadorEvento.ConexaoMySQL;

namespace GerenciadorEvento.View
{
    public partial class AtribuirSalaPart : Form
    {
        ControllerEstabelecimentos controllerEstabe = new ControllerEstabelecimentos();
        TrataDadosEstabelecimento trataDadosEstabe = new TrataDadosEstabelecimento();
        List<Estabelecimento> listaEstab;

        CriaConexao vinculaconexao = new CriaConexao();
        TrataDadosVincula tratadados = new TrataDadosVincula();

        ControllerSala controllerSalas = new ControllerSala();
        TrataDadosSala trataDadosSalas = new TrataDadosSala();
        List<Sala> listaSala;

        ControllerParticipantes controllerPart = new ControllerParticipantes();
        TrataDadosParticipantes trataDadosPart = new TrataDadosParticipantes();
        List<Participante> listaPart;

        public AtribuirSalaPart()
        {
            InitializeComponent();
            PreencheComboBoxSala();
            PreencheComboBoxPart();
        
        
        }


 


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telainicio inicio = new telainicio();
            this.Hide();
            inicio.ShowDialog();
        }

        private void btnVincParSa_Click(object sender, EventArgs e)
        {
            Participante part = new Participante();
            Sala sala = new Sala();
            Estabelecimento estabe = new Estabelecimento();

            estabe.IDEstabelecimento = listaEstab[comboBoxEstabe.SelectedIndex].IDEstabelecimento;
            part.IDParticipante = listaPart[comboBoxPart.SelectedIndex].IDParticipante;
            sala.IDSala = listaSala[comboBoxSala.SelectedIndex].IDSala;



            int idSala = listaSala[comboBoxSala.SelectedIndex].IDSala;
            int idpart = listaPart[comboBoxPart.SelectedIndex].IDParticipante;
            int idEstabe = listaEstab[comboBoxEstabe.SelectedIndex].IDEstabelecimento;

            //Do not use.
            int idlota = listaSala[comboBoxSala.SelectedIndex].Lotacao;

            if (tratadados.TrataDadosVinc(idpart, idSala, idEstabe))
            {
                if (vinculaconexao.VinculaSalaUsuario(listaPart[comboBoxPart.SelectedIndex].IDParticipante, listaSala[comboBoxSala.SelectedIndex].IDSala, listaEstab[comboBoxPart.SelectedIndex].IDEstabelecimento))
                {
                    MessageBox.Show("Participante Atribuido a Sala e local de Café!");
                }

                else
                {
                    MessageBox.Show("Erro ao Atribuir participante a sala ou ao local de Café!");

                }


            }
            else
                MessageBox.Show("Dados Inconsistentes!");


        }

        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxSala.SelectedIndex == -1)
                return;

            textBoxSala.Text = listaSala[comboBoxSala.SelectedIndex].NomeSala;
            textBoxLota.Text = listaSala[comboBoxSala.SelectedIndex].Lotacao.ToString();

        }

        private void comboBoxPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPart.SelectedIndex == -1)
                return;

            textBoxNome.Text = listaPart[comboBoxPart.SelectedIndex].Nome;
            textBoxSobrenome.Text = listaPart[comboBoxPart.SelectedIndex].SobreNome;
        }

        private void PreencheComboBoxSala()
        {
            listaSala = controllerSalas.CarregaSala();

            for (int indexSala = 0; indexSala < listaSala.Count(); indexSala++)
            {
                Sala salas = listaSala[indexSala];
                comboBoxSala.Items.Add(salas.NomeSala);
            }

        }

        private void PreencheComboBoxPart()
        {
            listaPart = controllerPart.CarregaParticipantes();

            for (int indexPart = 0; indexPart < listaPart.Count(); indexPart++)
            {
                Participante part = listaPart[indexPart];
                comboBoxPart.Items.Add(part.Nome);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEstabe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEstabe.SelectedIndex == -1)
                return;

            textBoxCafe.Text = listaEstab[comboBoxEstabe.SelectedIndex].NomeCafe;
            textBoxLotaCafe.Text = listaEstab[comboBoxEstabe.SelectedIndex].Lotacao.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            textBoxCafe.Text = "";
            textBoxLotaCafe.Text = "";

            textBoxLota.Text = "";
            textBoxSala.Text = "";

            textBoxNome.Text = "";
            textBoxSobrenome.Text = "";
        }

        private void AtribuirSalaPart_Load(object sender, EventArgs e)
        {

        }
    }
}
