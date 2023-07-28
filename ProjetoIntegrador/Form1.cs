using WinForms;

namespace ProjetoIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar usuario e senha no banco
            Conexao db = new Conexao();

            db.Conectar();

            UsuarioBanco usuario = new UsuarioBanco();
            usuario.Titular = titulartext.Text;
            usuario.Senha = senhatext.Text;

            //Buscar usuario e senha no banco de dados
            var retorno = db.BuscarUsuario(usuario.Titular, usuario.Senha);

            if (!retorno)
                MessageBox.Show("Titular ou senha incorretos! Tente Novamente...");

            if (retorno)
            {
                MessageBox.Show("Bem Vindo!");

                TelaUsuario telaUsuario = new TelaUsuario();

                telaUsuario.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RedefinirSenha redefinirSenha = new RedefinirSenha();
            redefinirSenha.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }
    }
}

