namespace PraticandocomArquivos
{
    partial class Form1_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_Login = new System.Windows.Forms.TextBox();
            this.textBox2_Senha = new System.Windows.Forms.TextBox();
            this.button1_Entrar = new System.Windows.Forms.Button();
            this.linkLabel1_cadastrese = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // textBox1_Login
            // 
            this.textBox1_Login.Location = new System.Drawing.Point(65, 21);
            this.textBox1_Login.Name = "textBox1_Login";
            this.textBox1_Login.Size = new System.Drawing.Size(255, 23);
            this.textBox1_Login.TabIndex = 2;
            // 
            // textBox2_Senha
            // 
            this.textBox2_Senha.Location = new System.Drawing.Point(65, 53);
            this.textBox2_Senha.Name = "textBox2_Senha";
            this.textBox2_Senha.Size = new System.Drawing.Size(255, 23);
            this.textBox2_Senha.TabIndex = 3;
            this.textBox2_Senha.UseSystemPasswordChar = true;
            // 
            // button1_Entrar
            // 
            this.button1_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Entrar.Location = new System.Drawing.Point(65, 82);
            this.button1_Entrar.Name = "button1_Entrar";
            this.button1_Entrar.Size = new System.Drawing.Size(255, 36);
            this.button1_Entrar.TabIndex = 4;
            this.button1_Entrar.Text = "Entrar";
            this.button1_Entrar.UseVisualStyleBackColor = true;
            this.button1_Entrar.Click += new System.EventHandler(this.button1_Entrar_Click);
            // 
            // linkLabel1_cadastrese
            // 
            this.linkLabel1_cadastrese.AutoSize = true;
            this.linkLabel1_cadastrese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1_cadastrese.Location = new System.Drawing.Point(154, 164);
            this.linkLabel1_cadastrese.Name = "linkLabel1_cadastrese";
            this.linkLabel1_cadastrese.Size = new System.Drawing.Size(69, 15);
            this.linkLabel1_cadastrese.TabIndex = 5;
            this.linkLabel1_cadastrese.TabStop = true;
            this.linkLabel1_cadastrese.Text = "Cadastre-se";
            this.linkLabel1_cadastrese.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_cadastrese_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(294, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "👀";
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // Form1_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 199);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1_cadastrese);
            this.Controls.Add(this.button1_Entrar);
            this.Controls.Add(this.textBox2_Senha);
            this.Controls.Add(this.textBox1_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1_Login;
        private TextBox textBox2_Senha;
        private Button button1_Entrar;
        private LinkLabel linkLabel1_cadastrese;
        private Label label3;
    }
}