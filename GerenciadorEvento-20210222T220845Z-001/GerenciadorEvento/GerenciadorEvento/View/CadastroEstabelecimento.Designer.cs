
namespace GerenciadorEvento.View
{
    partial class CadastroEstabelecimento
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
            this.textNomeCafe = new System.Windows.Forms.TextBox();
            this.textLotaCafe = new System.Windows.Forms.TextBox();
            this.btnConcluirCafe = new System.Windows.Forms.Button();
            this.btnCancelarCafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Estabelecimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lotação:";
            // 
            // textNomeCafe
            // 
            this.textNomeCafe.Location = new System.Drawing.Point(225, 74);
            this.textNomeCafe.Margin = new System.Windows.Forms.Padding(2);
            this.textNomeCafe.Name = "textNomeCafe";
            this.textNomeCafe.Size = new System.Drawing.Size(240, 20);
            this.textNomeCafe.TabIndex = 6;
            this.textNomeCafe.TextChanged += new System.EventHandler(this.textNomeCafe_TextChanged);
            // 
            // textLotaCafe
            // 
            this.textLotaCafe.Location = new System.Drawing.Point(106, 110);
            this.textLotaCafe.Margin = new System.Windows.Forms.Padding(2);
            this.textLotaCafe.Name = "textLotaCafe";
            this.textLotaCafe.Size = new System.Drawing.Size(51, 20);
            this.textLotaCafe.TabIndex = 7;
            // 
            // btnConcluirCafe
            // 
            this.btnConcluirCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirCafe.Location = new System.Drawing.Point(92, 186);
            this.btnConcluirCafe.Margin = new System.Windows.Forms.Padding(2);
            this.btnConcluirCafe.Name = "btnConcluirCafe";
            this.btnConcluirCafe.Size = new System.Drawing.Size(105, 30);
            this.btnConcluirCafe.TabIndex = 8;
            this.btnConcluirCafe.Text = "Concluir";
            this.btnConcluirCafe.UseVisualStyleBackColor = true;
            this.btnConcluirCafe.Click += new System.EventHandler(this.btnConcluirCafe_Click);
            // 
            // btnCancelarCafe
            // 
            this.btnCancelarCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCafe.Location = new System.Drawing.Point(326, 186);
            this.btnCancelarCafe.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCafe.Name = "btnCancelarCafe";
            this.btnCancelarCafe.Size = new System.Drawing.Size(105, 30);
            this.btnCancelarCafe.TabIndex = 10;
            this.btnCancelarCafe.Text = "Cancelar";
            this.btnCancelarCafe.UseVisualStyleBackColor = true;
            this.btnCancelarCafe.Click += new System.EventHandler(this.btnCancelarCafe_Click);
            // 
            // CadastroEstabelecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 286);
            this.Controls.Add(this.btnCancelarCafe);
            this.Controls.Add(this.btnConcluirCafe);
            this.Controls.Add(this.textLotaCafe);
            this.Controls.Add(this.textNomeCafe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroEstabelecimento";
            this.Text = "GerenciadorEstabelecimentocs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNomeCafe;
        private System.Windows.Forms.TextBox textLotaCafe;
        private System.Windows.Forms.Button btnConcluirCafe;
        private System.Windows.Forms.Button btnCancelarCafe;
    }
}