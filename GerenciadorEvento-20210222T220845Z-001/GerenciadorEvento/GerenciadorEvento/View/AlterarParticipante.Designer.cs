
namespace GerenciadorEvento.View
{
    partial class AlterarParticipante
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPart = new System.Windows.Forms.ComboBox();
            this.textNomePart = new System.Windows.Forms.TextBox();
            this.textSobrenomePart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterarPart = new System.Windows.Forms.Button();
            this.btnLimparPart = new System.Windows.Forms.Button();
            this.btnVoltarPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o participante:";
            // 
            // comboBoxPart
            // 
            this.comboBoxPart.FormattingEnabled = true;
            this.comboBoxPart.Location = new System.Drawing.Point(223, 25);
            this.comboBoxPart.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPart.Name = "comboBoxPart";
            this.comboBoxPart.Size = new System.Drawing.Size(158, 21);
            this.comboBoxPart.TabIndex = 1;
            this.comboBoxPart.SelectedIndexChanged += new System.EventHandler(this.comboBoxPart_SelectedIndexChanged);
            // 
            // textNomePart
            // 
            this.textNomePart.Enabled = false;
            this.textNomePart.Location = new System.Drawing.Point(192, 72);
            this.textNomePart.Margin = new System.Windows.Forms.Padding(2);
            this.textNomePart.Name = "textNomePart";
            this.textNomePart.Size = new System.Drawing.Size(240, 20);
            this.textNomePart.TabIndex = 16;
            // 
            // textSobrenomePart
            // 
            this.textSobrenomePart.Enabled = false;
            this.textSobrenomePart.Location = new System.Drawing.Point(192, 120);
            this.textSobrenomePart.Margin = new System.Windows.Forms.Padding(2);
            this.textSobrenomePart.Name = "textSobrenomePart";
            this.textSobrenomePart.Size = new System.Drawing.Size(240, 20);
            this.textSobrenomePart.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome:";
            // 
            // btnAlterarPart
            // 
            this.btnAlterarPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarPart.Location = new System.Drawing.Point(51, 202);
            this.btnAlterarPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarPart.Name = "btnAlterarPart";
            this.btnAlterarPart.Size = new System.Drawing.Size(105, 30);
            this.btnAlterarPart.TabIndex = 17;
            this.btnAlterarPart.Text = "Alterar";
            this.btnAlterarPart.UseVisualStyleBackColor = true;
            this.btnAlterarPart.Click += new System.EventHandler(this.btnAlterarPart_Click);
            // 
            // btnLimparPart
            // 
            this.btnLimparPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPart.Location = new System.Drawing.Point(216, 202);
            this.btnLimparPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparPart.Name = "btnLimparPart";
            this.btnLimparPart.Size = new System.Drawing.Size(105, 30);
            this.btnLimparPart.TabIndex = 18;
            this.btnLimparPart.Text = "Limpar";
            this.btnLimparPart.UseVisualStyleBackColor = true;
            this.btnLimparPart.Click += new System.EventHandler(this.btnConcluirPart_Click);
            // 
            // btnVoltarPart
            // 
            this.btnVoltarPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPart.Location = new System.Drawing.Point(380, 202);
            this.btnVoltarPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarPart.Name = "btnVoltarPart";
            this.btnVoltarPart.Size = new System.Drawing.Size(105, 30);
            this.btnVoltarPart.TabIndex = 19;
            this.btnVoltarPart.Text = "Voltar";
            this.btnVoltarPart.UseVisualStyleBackColor = true;
            this.btnVoltarPart.Click += new System.EventHandler(this.btnVoltarPart_Click);
            // 
            // AlterarParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 286);
            this.Controls.Add(this.btnVoltarPart);
            this.Controls.Add(this.btnLimparPart);
            this.Controls.Add(this.btnAlterarPart);
            this.Controls.Add(this.textNomePart);
            this.Controls.Add(this.textSobrenomePart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlterarParticipante";
            this.Text = "AlterarParticipante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPart;
        private System.Windows.Forms.TextBox textNomePart;
        private System.Windows.Forms.TextBox textSobrenomePart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterarPart;
        private System.Windows.Forms.Button btnLimparPart;
        private System.Windows.Forms.Button btnVoltarPart;
    }
}