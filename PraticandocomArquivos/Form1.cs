namespace PraticandocomArquivos
{
    public partial class Form1_Login : Form
    {
        List<Usuario> cadastroList = new List<Usuario>();
        Cadastro cadastro;
        public Form1_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_cadastrese_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            cadastro = new Cadastro();
            cadastro.ShowDialog();
            cadastro.Dispose();
            Show();
        }

        private void button1_Entrar_Click(object sender, EventArgs e)
        {

            if (camposPreenchidos() is false) { MessageBox.Show("Preencha todos os campos"); }
            else
            {
                if (buscarUsuarios())
                {
                    Hide();
                    new PaginaInicial().ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }

            LimparCampos();
        }
        public bool camposPreenchidos()
        {

            if(String.IsNullOrWhiteSpace(textBox1_Login.Text) || String.IsNullOrWhiteSpace(textBox2_Senha.Text))
            {
                return false;
            }

            return true;
        }
        private bool buscarUsuarios()
        {
            Util.LerDados();
            cadastroList = Util.retornaDados();

            foreach (var user in cadastroList)
            {
                if (user.getEmail() == textBox1_Login.Text && user.getSenha() == textBox2_Senha.Text)
                {
                    return true;
                   
                }
            }

            return false ;
        }

        private void LimparCampos()
        {
            textBox1_Login.Text = String.Empty;
            textBox2_Senha.Text = String.Empty;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            textBox2_Senha.UseSystemPasswordChar = false;
        
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            textBox2_Senha.UseSystemPasswordChar = true;
        }
    }
}