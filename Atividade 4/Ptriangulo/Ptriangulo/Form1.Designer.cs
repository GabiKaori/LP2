namespace Ptriangulo
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
            this.lblvalorA = new System.Windows.Forms.Label();
            this.lblvalorB = new System.Windows.Forms.Label();
            this.lblvalorC = new System.Windows.Forms.Label();
            this.txtvalorA = new System.Windows.Forms.TextBox();
            this.txtvalorB = new System.Windows.Forms.TextBox();
            this.txtvalorC = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvalorA
            // 
            this.lblvalorA.AutoSize = true;
            this.lblvalorA.Location = new System.Drawing.Point(96, 71);
            this.lblvalorA.Name = "lblvalorA";
            this.lblvalorA.Size = new System.Drawing.Size(83, 20);
            this.lblvalorA.TabIndex = 0;
            this.lblvalorA.Text = "Valor de A";
            // 
            // lblvalorB
            // 
            this.lblvalorB.AutoSize = true;
            this.lblvalorB.Location = new System.Drawing.Point(96, 149);
            this.lblvalorB.Name = "lblvalorB";
            this.lblvalorB.Size = new System.Drawing.Size(83, 20);
            this.lblvalorB.TabIndex = 1;
            this.lblvalorB.Text = "Valor de B";
            // 
            // lblvalorC
            // 
            this.lblvalorC.AutoSize = true;
            this.lblvalorC.Location = new System.Drawing.Point(96, 232);
            this.lblvalorC.Name = "lblvalorC";
            this.lblvalorC.Size = new System.Drawing.Size(83, 20);
            this.lblvalorC.TabIndex = 2;
            this.lblvalorC.Text = "Valor de C";
            // 
            // txtvalorA
            // 
            this.txtvalorA.Location = new System.Drawing.Point(242, 71);
            this.txtvalorA.Name = "txtvalorA";
            this.txtvalorA.Size = new System.Drawing.Size(149, 26);
            this.txtvalorA.TabIndex = 3;
            this.txtvalorA.Validating += new System.ComponentModel.CancelEventHandler(this.txtvalorA_Validating);
            // 
            // txtvalorB
            // 
            this.txtvalorB.Location = new System.Drawing.Point(242, 149);
            this.txtvalorB.Name = "txtvalorB";
            this.txtvalorB.Size = new System.Drawing.Size(149, 26);
            this.txtvalorB.TabIndex = 4;
            this.txtvalorB.Validating += new System.ComponentModel.CancelEventHandler(this.txtvalorB_Validating);
            // 
            // txtvalorC
            // 
            this.txtvalorC.Location = new System.Drawing.Point(242, 232);
            this.txtvalorC.Name = "txtvalorC";
            this.txtvalorC.Size = new System.Drawing.Size(149, 26);
            this.txtvalorC.TabIndex = 5;
            this.txtvalorC.Validating += new System.ComponentModel.CancelEventHandler(this.txtvalorC_Validating);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(100, 360);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(125, 68);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(310, 360);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 68);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(504, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 68);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 554);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtvalorC);
            this.Controls.Add(this.txtvalorB);
            this.Controls.Add(this.txtvalorA);
            this.Controls.Add(this.lblvalorC);
            this.Controls.Add(this.lblvalorB);
            this.Controls.Add(this.lblvalorA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalorA;
        private System.Windows.Forms.Label lblvalorB;
        private System.Windows.Forms.Label lblvalorC;
        private System.Windows.Forms.TextBox txtvalorA;
        private System.Windows.Forms.TextBox txtvalorB;
        private System.Windows.Forms.TextBox txtvalorC;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

