using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraticandocomArquivos
{
    public partial class Cadastro : Form
    {
        
        public Cadastro()
        {
            InitializeComponent();
            
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Cadastrar_Click(object sender, EventArgs e)
        {
            var nome = textBox1_Nome.Text;
            var email = textBox2_Email.Text;
            var senha = textBox3_Senha.Text;
            var confirmaSenha = textBox4_confirmaSenha.Text;


            if((String.IsNullOrWhiteSpace(nome) || String.IsNullOrWhiteSpace(email))
               || (String.IsNullOrWhiteSpace(senha) || (String.IsNullOrWhiteSpace(confirmaSenha)))){
                MessageBox.Show("Preencha todos os campos");
            }
            else if(senha != confirmaSenha)
            {
                MessageBox.Show("Senhas não conferem");
            }
            else
            {
                Util.GravaDados(nome, email, senha);
                
                MessageBox.Show("Cadastrado com sucesso");

                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            textBox1_Nome.Text = String.Empty;
            textBox2_Email.Text = String.Empty;
            textBox3_Senha.Text = String.Empty;
            textBox4_confirmaSenha.Text = String.Empty;
        }
    }
}
