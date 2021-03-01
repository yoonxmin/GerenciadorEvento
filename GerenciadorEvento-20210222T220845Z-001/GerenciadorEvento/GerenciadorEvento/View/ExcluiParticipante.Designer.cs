
namespace GerenciadorEvento.View
{
    partial class ExcluiParticipante
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
            this.btnVoltarPart = new System.Windows.Forms.Button();
            this.btnConcluirPart = new System.Windows.Forms.Button();
            this.btnExcluirPart = new System.Windows.Forms.Button();
            this.textNomePart = new System.Windows.Forms.TextBox();
            this.textSobrenomePart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltarPart
            // 
            this.btnVoltarPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPart.Location = new System.Drawing.Point(361, 176);
            this.btnVoltarPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarPart.Name = "btnVoltarPart";
            this.btnVoltarPart.Size = new System.Drawing.Size(105, 30);
            this.btnVoltarPart.TabIndex = 34;
            this.btnVoltarPart.Text = "Voltar";
            this.btnVoltarPart.UseVisualStyleBackColor = true;
            this.btnVoltarPart.Click += new System.EventHandler(this.btnVoltarPart_Click);
            // 
            // btnConcluirPart
            // 
            this.btnConcluirPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirPart.Location = new System.Drawing.Point(203, 176);
            this.btnConcluirPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnConcluirPart.Name = "btnConcluirPart";
            this.btnConcluirPart.Size = new System.Drawing.Size(105, 30);
            this.btnConcluirPart.TabIndex = 33;
            this.btnConcluirPart.Text = "Cancelar";
            this.btnConcluirPart.UseVisualStyleBackColor = true;
            // 
            // btnExcluirPart
            // 
            this.btnExcluirPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPart.Location = new System.Drawing.Point(48, 176);
            this.btnExcluirPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirPart.Name = "btnExcluirPart";
            this.btnExcluirPart.Size = new System.Drawing.Size(105, 30);
            this.btnExcluirPart.TabIndex = 32;
            this.btnExcluirPart.Text = "Excluir";
            this.btnExcluirPart.UseVisualStyleBackColor = true;
            this.btnExcluirPart.Click += new System.EventHandler(this.btnExcluirPart_Click);
            // 
            // textNomePart
            // 
            this.textNomePart.Enabled = false;
            this.textNomePart.HideSelection = false;
            this.textNomePart.Location = new System.Drawing.Point(172, 64);
            this.textNomePart.Margin = new System.Windows.Forms.Padding(2);
            this.textNomePart.Name = "textNomePart";
            this.textNomePart.Size = new System.Drawing.Size(240, 20);
            this.textNomePart.TabIndex = 31;
            // 
            // textSobrenomePart
            // 
            this.textSobrenomePart.Enabled = false;
            this.textSobrenomePart.HideSelection = false;
            this.textSobrenomePart.Location = new System.Drawing.Point(172, 112);
            this.textSobrenomePart.Margin = new System.Windows.Forms.Padding(2);
            this.textSobrenomePart.Name = "textSobrenomePart";
            this.textSobrenomePart.Size = new System.Drawing.Size(240, 20);
            this.textSobrenomePart.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nome:";
            // 
            // comboBoxPart
            // 
            this.comboBoxPart.FormattingEnabled = true;
            this.comboBoxPart.Location = new System.Drawing.Point(203, 17);
            this.comboBoxPart.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPart.Name = "comboBoxPart";
            this.comboBoxPart.Size = new System.Drawing.Size(158, 21);
            this.comboBoxPart.TabIndex = 27;
            this.comboBoxPart.SelectedIndexChanged += new System.EventHandler(this.comboBoxPart_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Selecione o participante:";
            // 
            // ExcluiParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 235);
            this.Controls.Add(this.btnVoltarPart);
            this.Controls.Add(this.btnConcluirPart);
            this.Controls.Add(this.btnExcluirPart);
            this.Controls.Add(this.textNomePart);
            this.Controls.Add(this.textSobrenomePart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExcluiParticipante";
            this.Text = "ExcluiParticipante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarPart;
        private System.Windows.Forms.Button btnConcluirPart;
        private System.Windows.Forms.Button btnExcluirPart;
        private System.Windows.Forms.TextBox textNomePart;
        private System.Windows.Forms.TextBox textSobrenomePart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPart;
        private System.Windows.Forms.Label label1;
    }
}