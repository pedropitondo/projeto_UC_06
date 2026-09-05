namespace Projeto_UC06
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
            this.gblogin = new System.Windows.Forms.GroupBox();
            this.brnentrar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.gblogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gblogin
            // 
            this.gblogin.BackColor = System.Drawing.Color.Transparent;
            this.gblogin.Controls.Add(this.brnentrar);
            this.gblogin.Controls.Add(this.textBox2);
            this.gblogin.Controls.Add(this.textBox1);
            this.gblogin.Controls.Add(this.label2);
            this.gblogin.Controls.Add(this.lblnome);
            this.gblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gblogin.ForeColor = System.Drawing.Color.White;
            this.gblogin.Location = new System.Drawing.Point(185, 76);
            this.gblogin.Name = "gblogin";
            this.gblogin.Size = new System.Drawing.Size(406, 279);
            this.gblogin.TabIndex = 0;
            this.gblogin.TabStop = false;
            this.gblogin.Text = "LOGIN/CADASTRO";
            // 
            // brnentrar
            // 
            this.brnentrar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.brnentrar.ForeColor = System.Drawing.Color.White;
            this.brnentrar.Location = new System.Drawing.Point(159, 219);
            this.brnentrar.Name = "brnentrar";
            this.brnentrar.Size = new System.Drawing.Size(90, 25);
            this.brnentrar.TabIndex = 4;
            this.brnentrar.Text = "ENTRAR";
            this.brnentrar.UseVisualStyleBackColor = false;
            this.brnentrar.Click += new System.EventHandler(this.brnentrar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(126, 51);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 16);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "NOME:";
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.Location = new System.Drawing.Point(25, 413);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(90, 25);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Projeto_UC06.Properties.Resources._2196508_fundo_preto_e_dourado_luxuoso_vetor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.gblogin);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.gblogin.ResumeLayout(false);
            this.gblogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gblogin;
        private System.Windows.Forms.Button brnentrar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnsair;
    }
}

