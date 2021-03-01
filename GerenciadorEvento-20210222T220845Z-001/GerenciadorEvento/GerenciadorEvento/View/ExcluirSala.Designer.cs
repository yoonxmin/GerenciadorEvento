
namespace GerenciadorEvento.View
{
    partial class ExcluirSala
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
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.textNomeSala = new System.Windows.Forms.TextBox();
            this.textLotaSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluirSala = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Location = new System.Drawing.Point(206, 32);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(175, 21);
            this.comboBoxSala.TabIndex = 0;
            this.comboBoxSala.SelectedIndexChanged += new System.EventHandler(this.comboBoxSala_SelectedIndexChanged_1);
            // 
            // textNomeSala
            // 
            this.textNomeSala.Enabled = false;
            this.textNomeSala.HideSelection = false;
            this.textNomeSala.Location = new System.Drawing.Point(164, 76);
            this.textNomeSala.Name = "textNomeSala";
            this.textNomeSala.Size = new System.Drawing.Size(246, 20);
            this.textNomeSala.TabIndex = 1;
            // 
            // textLotaSala
            // 
            this.textLotaSala.Enabled = false;
            this.textLotaSala.HideSelection = false;
            this.textLotaSala.Location = new System.Drawing.Point(164, 105);
            this.textLotaSala.Name = "textLotaSala";
            this.textLotaSala.Size = new System.Drawing.Size(76, 20);
            this.textLotaSala.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lotação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Sala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecione a Sala:";
            // 
            // btnExcluirSala
            // 
            this.btnExcluirSala.Location = new System.Drawing.Point(58, 175);
            this.btnExcluirSala.Name = "btnExcluirSala";
            this.btnExcluirSala.Size = new System.Drawing.Size(105, 30);
            this.btnExcluirSala.TabIndex = 6;
            this.btnExcluirSala.Text = "Excluir";
            this.btnExcluirSala.UseVisualStyleBackColor = true;
            this.btnExcluirSala.Click += new System.EventHandler(this.btnExcluirSala_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(347, 175);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 30);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ExcluirSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 235);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluirSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLotaSala);
            this.Controls.Add(this.textNomeSala);
            this.Controls.Add(this.comboBoxSala);
            this.Name = "ExcluirSala";
            this.Text = "ExcluirSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.TextBox textNomeSala;
        private System.Windows.Forms.TextBox textLotaSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluirSala;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVoltar;
    }
}