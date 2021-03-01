
namespace GerenciadorEvento.View
{
    partial class CadastroSalas
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
            this.label2 = new System.Windows.Forms.Label();
            this.textNomeSala = new System.Windows.Forms.TextBox();
            this.textLotaSala = new System.Windows.Forms.TextBox();
            this.btnConcluirSala = new System.Windows.Forms.Button();
            this.btnCancelarSala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lotação:";
            // 
            // textNomeSala
            // 
            this.textNomeSala.Location = new System.Drawing.Point(180, 74);
            this.textNomeSala.Margin = new System.Windows.Forms.Padding(2);
            this.textNomeSala.Name = "textNomeSala";
            this.textNomeSala.Size = new System.Drawing.Size(240, 20);
            this.textNomeSala.TabIndex = 5;
            this.textNomeSala.TextChanged += new System.EventHandler(this.textNomePart_TextChanged);
            // 
            // textLotaSala
            // 
            this.textLotaSala.Location = new System.Drawing.Point(180, 105);
            this.textLotaSala.Margin = new System.Windows.Forms.Padding(2);
            this.textLotaSala.Name = "textLotaSala";
            this.textLotaSala.Size = new System.Drawing.Size(50, 20);
            this.textLotaSala.TabIndex = 6;
            // 
            // btnConcluirSala
            // 
            this.btnConcluirSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirSala.Location = new System.Drawing.Point(82, 176);
            this.btnConcluirSala.Margin = new System.Windows.Forms.Padding(2);
            this.btnConcluirSala.Name = "btnConcluirSala";
            this.btnConcluirSala.Size = new System.Drawing.Size(105, 30);
            this.btnConcluirSala.TabIndex = 7;
            this.btnConcluirSala.Text = "Concluir";
            this.btnConcluirSala.UseVisualStyleBackColor = true;
            this.btnConcluirSala.Click += new System.EventHandler(this.btnConcluirSala_Click);
            // 
            // btnCancelarSala
            // 
            this.btnCancelarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSala.Location = new System.Drawing.Point(315, 176);
            this.btnCancelarSala.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarSala.Name = "btnCancelarSala";
            this.btnCancelarSala.Size = new System.Drawing.Size(105, 30);
            this.btnCancelarSala.TabIndex = 9;
            this.btnCancelarSala.Text = "Cancelar";
            this.btnCancelarSala.UseVisualStyleBackColor = true;
            this.btnCancelarSala.Click += new System.EventHandler(this.btnCancelarSala_Click);
            this.btnCancelarSala.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCancelarSala_MouseClick);
            // 
            // CadastroSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 286);
            this.Controls.Add(this.btnCancelarSala);
            this.Controls.Add(this.btnConcluirSala);
            this.Controls.Add(this.textLotaSala);
            this.Controls.Add(this.textNomeSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroSalas";
            this.Text = "GerenciadorSalas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNomeSala;
        private System.Windows.Forms.TextBox textLotaSala;
        private System.Windows.Forms.Button btnConcluirSala;
        private System.Windows.Forms.Button btnCancelarSala;
    }
}