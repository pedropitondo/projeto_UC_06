namespace Projeto_UC06
{
    partial class frmagendar
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
            this.lblagendamento = new System.Windows.Forms.Label();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnprodutos = new System.Windows.Forms.Button();
            this.btnvendas = new System.Windows.Forms.Button();
            this.btnlogoff = new System.Windows.Forms.Button();
            this.btncadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblagendamento
            // 
            this.lblagendamento.AutoSize = true;
            this.lblagendamento.BackColor = System.Drawing.Color.Transparent;
            this.lblagendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagendamento.ForeColor = System.Drawing.Color.White;
            this.lblagendamento.Location = new System.Drawing.Point(95, 23);
            this.lblagendamento.Name = "lblagendamento";
            this.lblagendamento.Size = new System.Drawing.Size(335, 29);
            this.lblagendamento.TabIndex = 0;
            this.lblagendamento.Text = "AGENDAMENTO TECNICO";
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Location = new System.Drawing.Point(71, 168);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(100, 25);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "CLIENTES";
            this.btnclientes.UseVisualStyleBackColor = false;
            // 
            // btnprodutos
            // 
            this.btnprodutos.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprodutos.ForeColor = System.Drawing.Color.White;
            this.btnprodutos.Location = new System.Drawing.Point(209, 168);
            this.btnprodutos.Name = "btnprodutos";
            this.btnprodutos.Size = new System.Drawing.Size(100, 25);
            this.btnprodutos.TabIndex = 2;
            this.btnprodutos.Text = "PRODUTOS";
            this.btnprodutos.UseVisualStyleBackColor = false;
            // 
            // btnvendas
            // 
            this.btnvendas.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnvendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendas.ForeColor = System.Drawing.Color.White;
            this.btnvendas.Location = new System.Drawing.Point(358, 168);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Size = new System.Drawing.Size(100, 25);
            this.btnvendas.TabIndex = 3;
            this.btnvendas.Text = "VENDAS";
            this.btnvendas.UseVisualStyleBackColor = false;
            // 
            // btnlogoff
            // 
            this.btnlogoff.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnlogoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogoff.ForeColor = System.Drawing.Color.White;
            this.btnlogoff.Location = new System.Drawing.Point(429, 363);
            this.btnlogoff.Name = "btnlogoff";
            this.btnlogoff.Size = new System.Drawing.Size(75, 23);
            this.btnlogoff.TabIndex = 4;
            this.btnlogoff.Text = "LOGOFF";
            this.btnlogoff.UseVisualStyleBackColor = false;
            // 
            // btncadastro
            // 
            this.btncadastro.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btncadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastro.ForeColor = System.Drawing.Color.White;
            this.btncadastro.Location = new System.Drawing.Point(151, 266);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(219, 23);
            this.btncadastro.TabIndex = 5;
            this.btncadastro.Text = "CADASTRAR FUNCIONARIO";
            this.btncadastro.UseVisualStyleBackColor = false;
            // 
            // frmagendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_UC06.Properties.Resources._2196508_fundo_preto_e_dourado_luxuoso_vetor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 398);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.btnlogoff);
            this.Controls.Add(this.btnvendas);
            this.Controls.Add(this.btnprodutos);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.lblagendamento);
            this.Name = "frmagendar";
            this.Text = "AGENDAMENTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblagendamento;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnprodutos;
        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Button btnlogoff;
        private System.Windows.Forms.Button btncadastro;
    }
}