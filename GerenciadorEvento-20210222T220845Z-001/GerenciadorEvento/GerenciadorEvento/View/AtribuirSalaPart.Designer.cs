
namespace GerenciadorEvento.View
{
    partial class AtribuirSalaPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPart = new System.Windows.Forms.ComboBox();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVincParSa = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSala = new System.Windows.Forms.TextBox();
            this.textBoxLota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLotaCafe = new System.Windows.Forms.TextBox();
            this.textBoxCafe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxEstabe = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPart
            // 
            this.comboBoxPart.FormattingEnabled = true;
            this.comboBoxPart.Location = new System.Drawing.Point(257, 63);
            this.comboBoxPart.Name = "comboBoxPart";
            this.comboBoxPart.Size = new System.Drawing.Size(202, 21);
            this.comboBoxPart.TabIndex = 1;
            this.comboBoxPart.SelectedIndexChanged += new System.EventHandler(this.comboBoxPart_SelectedIndexChanged);
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Location = new System.Drawing.Point(257, 28);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(202, 21);
            this.comboBoxSala.TabIndex = 2;
            this.comboBoxSala.SelectedIndexChanged += new System.EventHandler(this.comboBoxSala_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione uma Sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione um Participante:";
            // 
            // btnVincParSa
            // 
            this.btnVincParSa.BackColor = System.Drawing.SystemColors.Control;
            this.btnVincParSa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVincParSa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincParSa.Location = new System.Drawing.Point(388, 299);
            this.btnVincParSa.Name = "btnVincParSa";
            this.btnVincParSa.Size = new System.Drawing.Size(102, 32);
            this.btnVincParSa.TabIndex = 5;
            this.btnVincParSa.Text = "Vincular";
            this.btnVincParSa.UseVisualStyleBackColor = false;
            this.btnVincParSa.Click += new System.EventHandler(this.btnVincParSa_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(388, 402);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 32);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Enabled = false;
            this.textBoxNome.HideSelection = false;
            this.textBoxNome.Location = new System.Drawing.Point(123, 150);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(226, 20);
            this.textBoxNome.TabIndex = 7;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Enabled = false;
            this.textBoxSobrenome.HideSelection = false;
            this.textBoxSobrenome.Location = new System.Drawing.Point(123, 185);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(226, 20);
            this.textBoxSobrenome.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sobrenome:";
            // 
            // textBoxSala
            // 
            this.textBoxSala.Enabled = false;
            this.textBoxSala.HideSelection = false;
            this.textBoxSala.Location = new System.Drawing.Point(123, 240);
            this.textBoxSala.Name = "textBoxSala";
            this.textBoxSala.Size = new System.Drawing.Size(226, 20);
            this.textBoxSala.TabIndex = 11;
            // 
            // textBoxLota
            // 
            this.textBoxLota.Enabled = false;
            this.textBoxLota.HideSelection = false;
            this.textBoxLota.Location = new System.Drawing.Point(123, 277);
            this.textBoxLota.Name = "textBoxLota";
            this.textBoxLota.Size = new System.Drawing.Size(52, 20);
            this.textBoxLota.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lotação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lotação:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Café:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxLotaCafe
            // 
            this.textBoxLotaCafe.Enabled = false;
            this.textBoxLotaCafe.HideSelection = false;
            this.textBoxLotaCafe.Location = new System.Drawing.Point(123, 377);
            this.textBoxLotaCafe.Name = "textBoxLotaCafe";
            this.textBoxLotaCafe.Size = new System.Drawing.Size(52, 20);
            this.textBoxLotaCafe.TabIndex = 17;
            // 
            // textBoxCafe
            // 
            this.textBoxCafe.Enabled = false;
            this.textBoxCafe.HideSelection = false;
            this.textBoxCafe.Location = new System.Drawing.Point(123, 342);
            this.textBoxCafe.Name = "textBoxCafe";
            this.textBoxCafe.Size = new System.Drawing.Size(226, 20);
            this.textBoxCafe.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Selecione um Estabelecimento:";
            // 
            // comboBoxEstabe
            // 
            this.comboBoxEstabe.FormattingEnabled = true;
            this.comboBoxEstabe.Location = new System.Drawing.Point(257, 100);
            this.comboBoxEstabe.Name = "comboBoxEstabe";
            this.comboBoxEstabe.Size = new System.Drawing.Size(202, 21);
            this.comboBoxEstabe.TabIndex = 20;
            this.comboBoxEstabe.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstabe_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(388, 346);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 32);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // AtribuirSalaPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 446);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.comboBoxEstabe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCafe);
            this.Controls.Add(this.textBoxLotaCafe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLota);
            this.Controls.Add(this.textBoxSala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVincParSa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSala);
            this.Controls.Add(this.comboBoxPart);
            this.Name = "AtribuirSalaPart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AtribuirSalaPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPart;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVincParSa;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSala;
        private System.Windows.Forms.TextBox textBoxLota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLotaCafe;
        private System.Windows.Forms.TextBox textBoxCafe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxEstabe;
        private System.Windows.Forms.Button btnLimpar;
    }
}