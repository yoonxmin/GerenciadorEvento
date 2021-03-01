
namespace GerenciadorEvento.View
{
    partial class CadastroParticipante
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
            this.btnConcluirPart = new System.Windows.Forms.Button();
            this.textNomePart = new System.Windows.Forms.TextBox();
            this.textSobrenomePart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConcluirPart
            // 
            this.btnConcluirPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirPart.Location = new System.Drawing.Point(117, 177);
            this.btnConcluirPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConcluirPart.Name = "btnConcluirPart";
            this.btnConcluirPart.Size = new System.Drawing.Size(105, 30);
            this.btnConcluirPart.TabIndex = 13;
            this.btnConcluirPart.Text = "Concluir";
            this.btnConcluirPart.UseVisualStyleBackColor = true;
            this.btnConcluirPart.Click += new System.EventHandler(this.btnConcluirPart_Click);
            // 
            // textNomePart
            // 
            this.textNomePart.Location = new System.Drawing.Point(190, 68);
            this.textNomePart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNomePart.Name = "textNomePart";
            this.textNomePart.Size = new System.Drawing.Size(240, 20);
            this.textNomePart.TabIndex = 12;
            // 
            // textSobrenomePart
            // 
            this.textSobrenomePart.Location = new System.Drawing.Point(190, 110);
            this.textSobrenomePart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSobrenomePart.Name = "textSobrenomePart";
            this.textSobrenomePart.Size = new System.Drawing.Size(240, 20);
            this.textSobrenomePart.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sobrenome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // btnVoltarPart
            // 
            this.btnVoltarPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPart.Location = new System.Drawing.Point(312, 177);
            this.btnVoltarPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltarPart.Name = "btnVoltarPart";
            this.btnVoltarPart.Size = new System.Drawing.Size(105, 30);
            this.btnVoltarPart.TabIndex = 14;
            this.btnVoltarPart.Text = "Voltar";
            this.btnVoltarPart.UseVisualStyleBackColor = true;
            this.btnVoltarPart.Click += new System.EventHandler(this.btnVoltarPart_Click);
            // 
            // CadastroParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 286);
            this.Controls.Add(this.btnVoltarPart);
            this.Controls.Add(this.btnConcluirPart);
            this.Controls.Add(this.textNomePart);
            this.Controls.Add(this.textSobrenomePart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CadastroParticipante";
            this.Text = "CadastroParticipante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConcluirPart;
        private System.Windows.Forms.TextBox textNomePart;
        private System.Windows.Forms.TextBox textSobrenomePart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarPart;
    }
}