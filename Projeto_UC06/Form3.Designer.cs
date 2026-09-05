namespace Projeto_UC06
{
    partial class frmcadastro
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
            this.gbcadastro = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblativoinativo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbcadastro.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbcadastro
            // 
            this.gbcadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbcadastro.Controls.Add(this.comboBox1);
            this.gbcadastro.Controls.Add(this.lblativoinativo);
            this.gbcadastro.Controls.Add(this.textBox2);
            this.gbcadastro.Controls.Add(this.textBox1);
            this.gbcadastro.Controls.Add(this.lblsenha);
            this.gbcadastro.Controls.Add(this.lblnome);
            this.gbcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcadastro.ForeColor = System.Drawing.Color.White;
            this.gbcadastro.Location = new System.Drawing.Point(12, 12);
            this.gbcadastro.Name = "gbcadastro";
            this.gbcadastro.Size = new System.Drawing.Size(264, 207);
            this.gbcadastro.TabIndex = 0;
            this.gbcadastro.TabStop = false;
            this.gbcadastro.Text = "CADASTRO DE USUARIO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // lblativoinativo
            // 
            this.lblativoinativo.AutoSize = true;
            this.lblativoinativo.Location = new System.Drawing.Point(6, 141);
            this.lblativoinativo.Name = "lblativoinativo";
            this.lblativoinativo.Size = new System.Drawing.Size(117, 16);
            this.lblativoinativo.TabIndex = 4;
            this.lblativoinativo.Text = "ATIVO/INATIVO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(6, 87);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(63, 16);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "SENHA:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(6, 30);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 16);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "NOME:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "INCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(103, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(569, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "FECHAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.dataGridView1);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.ForeColor = System.Drawing.Color.White;
            this.gb1.Location = new System.Drawing.Point(326, 15);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(314, 204);
            this.gb1.TabIndex = 5;
            this.gb1.TabStop = false;
            this.gb1.Text = "USUARIOS CADASTRADOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_UC06.Properties.Resources._2196508_fundo_preto_e_dourado_luxuoso_vetor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 292);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbcadastro);
            this.Name = "frmcadastro";
            this.Text = "CADASTRO DE USUARIO";
            this.gbcadastro.ResumeLayout(false);
            this.gbcadastro.PerformLayout();
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcadastro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblativoinativo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}