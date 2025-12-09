namespace SimuladorDeVotos
{
    partial class Form1
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
            this.btCadrasto = new System.Windows.Forms.Button();
            this.btVotacaoIntera = new System.Windows.Forms.Button();
            this.btApuracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU DE OPÇÕES:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadrasto
            // 
            this.btCadrasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCadrasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadrasto.Location = new System.Drawing.Point(197, 134);
            this.btCadrasto.Name = "btCadrasto";
            this.btCadrasto.Size = new System.Drawing.Size(361, 50);
            this.btCadrasto.TabIndex = 1;
            this.btCadrasto.Text = "CADRASTO DE CANDIDATOS";
            this.btCadrasto.UseVisualStyleBackColor = false;
            this.btCadrasto.Click += new System.EventHandler(this.btCadrasto_Click);
            // 
            // btVotacaoIntera
            // 
            this.btVotacaoIntera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btVotacaoIntera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotacaoIntera.Location = new System.Drawing.Point(197, 207);
            this.btVotacaoIntera.Name = "btVotacaoIntera";
            this.btVotacaoIntera.Size = new System.Drawing.Size(361, 50);
            this.btVotacaoIntera.TabIndex = 2;
            this.btVotacaoIntera.Text = "VOTAÇÃO INTERATIVA";
            this.btVotacaoIntera.UseVisualStyleBackColor = false;
            // 
            // btApuracao
            // 
            this.btApuracao.BackColor = System.Drawing.Color.Green;
            this.btApuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApuracao.Location = new System.Drawing.Point(197, 296);
            this.btApuracao.Name = "btApuracao";
            this.btApuracao.Size = new System.Drawing.Size(361, 50);
            this.btApuracao.TabIndex = 3;
            this.btApuracao.Text = "APURAÇÃO DE VOTOS";
            this.btApuracao.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btApuracao);
            this.Controls.Add(this.btVotacaoIntera);
            this.Controls.Add(this.btCadrasto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadrasto;
        private System.Windows.Forms.Button btVotacaoIntera;
        private System.Windows.Forms.Button btApuracao;
    }
}

