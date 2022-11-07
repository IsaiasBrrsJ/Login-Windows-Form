namespace PraticandocomArquivos
{
    partial class Cadastro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_Nome = new System.Windows.Forms.TextBox();
            this.textBox3_Senha = new System.Windows.Forms.TextBox();
            this.textBox4_confirmaSenha = new System.Windows.Forms.TextBox();
            this.textBox2_Email = new System.Windows.Forms.TextBox();
            this.button1_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirma senha";
            // 
            // textBox1_Nome
            // 
            this.textBox1_Nome.Location = new System.Drawing.Point(68, 27);
            this.textBox1_Nome.Name = "textBox1_Nome";
            this.textBox1_Nome.Size = new System.Drawing.Size(240, 23);
            this.textBox1_Nome.TabIndex = 1;
            // 
            // textBox3_Senha
            // 
            this.textBox3_Senha.Location = new System.Drawing.Point(71, 107);
            this.textBox3_Senha.Name = "textBox3_Senha";
            this.textBox3_Senha.Size = new System.Drawing.Size(237, 23);
            this.textBox3_Senha.TabIndex = 3;
            // 
            // textBox4_confirmaSenha
            // 
            this.textBox4_confirmaSenha.Location = new System.Drawing.Point(130, 142);
            this.textBox4_confirmaSenha.Name = "textBox4_confirmaSenha";
            this.textBox4_confirmaSenha.Size = new System.Drawing.Size(178, 23);
            this.textBox4_confirmaSenha.TabIndex = 4;
            // 
            // textBox2_Email
            // 
            this.textBox2_Email.Location = new System.Drawing.Point(68, 65);
            this.textBox2_Email.Name = "textBox2_Email";
            this.textBox2_Email.Size = new System.Drawing.Size(240, 23);
            this.textBox2_Email.TabIndex = 2;
            // 
            // button1_Cadastrar
            // 
            this.button1_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Cadastrar.Location = new System.Drawing.Point(16, 194);
            this.button1_Cadastrar.Name = "button1_Cadastrar";
            this.button1_Cadastrar.Size = new System.Drawing.Size(292, 39);
            this.button1_Cadastrar.TabIndex = 5;
            this.button1_Cadastrar.Text = "Cadastrar";
            this.button1_Cadastrar.UseVisualStyleBackColor = true;
            this.button1_Cadastrar.Click += new System.EventHandler(this.button1_Cadastrar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 260);
            this.Controls.Add(this.button1_Cadastrar);
            this.Controls.Add(this.textBox2_Email);
            this.Controls.Add(this.textBox4_confirmaSenha);
            this.Controls.Add(this.textBox3_Senha);
            this.Controls.Add(this.textBox1_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1_Nome;
        private TextBox textBox3_Senha;
        private TextBox textBox4_confirmaSenha;
        private TextBox textBox2_Email;
        private Button button1_Cadastrar;
    }
}