
namespace GerenciadorEvento.View
{
    partial class GerenciadorEstabelecimento
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
            System.Windows.Forms.Button btnAdicionarEstabe;
            this.btnExluirEstabe = new System.Windows.Forms.Button();
            this.btnAlterarEstabe = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            btnAdicionarEstabe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarEstabe
            // 
            btnAdicionarEstabe.Location = new System.Drawing.Point(201, 28);
            btnAdicionarEstabe.Name = "btnAdicionarEstabe";
            btnAdicionarEstabe.Size = new System.Drawing.Size(105, 44);
            btnAdicionarEstabe.TabIndex = 0;
            btnAdicionarEstabe.Text = "Adicionar";
            btnAdicionarEstabe.UseVisualStyleBackColor = true;
            btnAdicionarEstabe.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExluirEstabe
            // 
            this.btnExluirEstabe.Location = new System.Drawing.Point(201, 97);
            this.btnExluirEstabe.Name = "btnExluirEstabe";
            this.btnExluirEstabe.Size = new System.Drawing.Size(105, 44);
            this.btnExluirEstabe.TabIndex = 1;
            this.btnExluirEstabe.Text = "Excluir";
            this.btnExluirEstabe.UseVisualStyleBackColor = true;
            this.btnExluirEstabe.Click += new System.EventHandler(this.btnExluirEstabe_Click);
            // 
            // btnAlterarEstabe
            // 
            this.btnAlterarEstabe.Location = new System.Drawing.Point(201, 165);
            this.btnAlterarEstabe.Name = "btnAlterarEstabe";
            this.btnAlterarEstabe.Size = new System.Drawing.Size(105, 44);
            this.btnAlterarEstabe.TabIndex = 2;
            this.btnAlterarEstabe.Text = "Alterar Estabelecimento";
            this.btnAlterarEstabe.UseVisualStyleBackColor = true;
            this.btnAlterarEstabe.Click += new System.EventHandler(this.btnAlterarEstabe_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(201, 230);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 44);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // GerenciadorEstabelecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 286);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterarEstabe);
            this.Controls.Add(this.btnExluirEstabe);
            this.Controls.Add(btnAdicionarEstabe);
            this.Name = "GerenciadorEstabelecimento";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExluirEstabe;
        private System.Windows.Forms.Button btnAlterarEstabe;
        private System.Windows.Forms.Button btnVoltar;
    }
}