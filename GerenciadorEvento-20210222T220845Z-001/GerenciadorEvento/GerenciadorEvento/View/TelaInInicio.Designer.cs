
namespace GerenciadorEvento
{
    partial class telainicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerenPart = new System.Windows.Forms.Button();
            this.btnGerenEstabe = new System.Windows.Forms.Button();
            this.btnGerenSala = new System.Windows.Forms.Button();
            this.btnVincular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao Gerenciador";
            // 
            // btnGerenPart
            // 
            this.btnGerenPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenPart.Location = new System.Drawing.Point(216, 75);
            this.btnGerenPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerenPart.Name = "btnGerenPart";
            this.btnGerenPart.Size = new System.Drawing.Size(243, 46);
            this.btnGerenPart.TabIndex = 1;
            this.btnGerenPart.Text = "Gerenciar Participantes";
            this.btnGerenPart.UseVisualStyleBackColor = true;
            this.btnGerenPart.Click += new System.EventHandler(this.btnGerenPart_Click);
            // 
            // btnGerenEstabe
            // 
            this.btnGerenEstabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenEstabe.Location = new System.Drawing.Point(216, 207);
            this.btnGerenEstabe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerenEstabe.Name = "btnGerenEstabe";
            this.btnGerenEstabe.Size = new System.Drawing.Size(243, 58);
            this.btnGerenEstabe.TabIndex = 2;
            this.btnGerenEstabe.Text = "Gerenciar Estabelecimentos";
            this.btnGerenEstabe.UseVisualStyleBackColor = true;
            this.btnGerenEstabe.Click += new System.EventHandler(this.btnGerenEstabe_Click);
            // 
            // btnGerenSala
            // 
            this.btnGerenSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenSala.Location = new System.Drawing.Point(216, 138);
            this.btnGerenSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerenSala.Name = "btnGerenSala";
            this.btnGerenSala.Size = new System.Drawing.Size(243, 49);
            this.btnGerenSala.TabIndex = 3;
            this.btnGerenSala.Text = "Gerenciar Salas";
            this.btnGerenSala.UseVisualStyleBackColor = true;
            this.btnGerenSala.Click += new System.EventHandler(this.btnGerenSala_Click);
            // 
            // btnVincular
            // 
            this.btnVincular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincular.Location = new System.Drawing.Point(216, 278);
            this.btnVincular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(243, 60);
            this.btnVincular.TabIndex = 4;
            this.btnVincular.Text = "Gerenciar Participantes nas Salas";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // telainicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 352);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.btnGerenSala);
            this.Controls.Add(this.btnGerenEstabe);
            this.Controls.Add(this.btnGerenPart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "telainicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerenPart;
        private System.Windows.Forms.Button btnGerenEstabe;
        private System.Windows.Forms.Button btnGerenSala;
        private System.Windows.Forms.Button btnVincular;
    }
}

