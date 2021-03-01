
namespace GerenciadorEvento.View
{
    partial class GerenciadorParticipantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciadorParticipantes));
            this.btnCadastrarPart = new System.Windows.Forms.Button();
            this.btnAlterarPart = new System.Windows.Forms.Button();
            this.btnExcluirPart = new System.Windows.Forms.Button();
            this.VoltarPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarPart
            // 
            resources.ApplyResources(this.btnCadastrarPart, "btnCadastrarPart");
            this.btnCadastrarPart.Name = "btnCadastrarPart";
            this.btnCadastrarPart.UseVisualStyleBackColor = true;
            this.btnCadastrarPart.Click += new System.EventHandler(this.btnCadastrarPart_Click);
            // 
            // btnAlterarPart
            // 
            resources.ApplyResources(this.btnAlterarPart, "btnAlterarPart");
            this.btnAlterarPart.Name = "btnAlterarPart";
            this.btnAlterarPart.UseVisualStyleBackColor = true;
            this.btnAlterarPart.Click += new System.EventHandler(this.btnAlterarPart_Click);
            // 
            // btnExcluirPart
            // 
            resources.ApplyResources(this.btnExcluirPart, "btnExcluirPart");
            this.btnExcluirPart.Name = "btnExcluirPart";
            this.btnExcluirPart.UseVisualStyleBackColor = true;
            this.btnExcluirPart.Click += new System.EventHandler(this.btnExcluirPart_Click);
            // 
            // VoltarPart
            // 
            resources.ApplyResources(this.VoltarPart, "VoltarPart");
            this.VoltarPart.Name = "VoltarPart";
            this.VoltarPart.UseVisualStyleBackColor = true;
            this.VoltarPart.Click += new System.EventHandler(this.VoltarPart_Click);
            // 
            // GerenciadorParticipantes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VoltarPart);
            this.Controls.Add(this.btnExcluirPart);
            this.Controls.Add(this.btnAlterarPart);
            this.Controls.Add(this.btnCadastrarPart);
            this.Name = "GerenciadorParticipantes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarPart;
        private System.Windows.Forms.Button btnAlterarPart;
        private System.Windows.Forms.Button btnExcluirPart;
        private System.Windows.Forms.Button VoltarPart;
    }
}