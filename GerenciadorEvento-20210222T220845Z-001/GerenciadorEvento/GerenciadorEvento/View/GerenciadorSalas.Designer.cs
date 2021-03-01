
namespace GerenciadorEvento.View
{
    partial class GerenciadorSalas
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
            this.btnCadastrarSala = new System.Windows.Forms.Button();
            this.btnAlterarSala = new System.Windows.Forms.Button();
            this.btnExcluirSala = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarSala
            // 
            this.btnCadastrarSala.Location = new System.Drawing.Point(264, 41);
            this.btnCadastrarSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarSala.Name = "btnCadastrarSala";
            this.btnCadastrarSala.Size = new System.Drawing.Size(140, 37);
            this.btnCadastrarSala.TabIndex = 0;
            this.btnCadastrarSala.Text = "Cadastrar";
            this.btnCadastrarSala.UseVisualStyleBackColor = true;
            this.btnCadastrarSala.Click += new System.EventHandler(this.btnCadastrarSala_Click);
            // 
            // btnAlterarSala
            // 
            this.btnAlterarSala.Location = new System.Drawing.Point(264, 111);
            this.btnAlterarSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterarSala.Name = "btnAlterarSala";
            this.btnAlterarSala.Size = new System.Drawing.Size(140, 37);
            this.btnAlterarSala.TabIndex = 1;
            this.btnAlterarSala.Text = "Alterar";
            this.btnAlterarSala.UseVisualStyleBackColor = true;
            this.btnAlterarSala.Click += new System.EventHandler(this.btnAlterarSala_Click);
            // 
            // btnExcluirSala
            // 
            this.btnExcluirSala.Location = new System.Drawing.Point(264, 185);
            this.btnExcluirSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirSala.Name = "btnExcluirSala";
            this.btnExcluirSala.Size = new System.Drawing.Size(140, 37);
            this.btnExcluirSala.TabIndex = 2;
            this.btnExcluirSala.Text = "Excluir Sala";
            this.btnExcluirSala.UseVisualStyleBackColor = true;
            this.btnExcluirSala.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(264, 274);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 37);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // GerenciadorSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 352);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluirSala);
            this.Controls.Add(this.btnAlterarSala);
            this.Controls.Add(this.btnCadastrarSala);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GerenciadorSalas";
            this.Text = "GerenciadorSalas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarSala;
        private System.Windows.Forms.Button btnAlterarSala;
        private System.Windows.Forms.Button btnExcluirSala;
        private System.Windows.Forms.Button btnVoltar;
    }
}