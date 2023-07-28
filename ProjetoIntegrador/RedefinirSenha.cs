using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;

namespace ProjetoIntegrador
{
    public partial class RedefinirSenha : Form

    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text.Length > 0 && textBoxSenha.MaxLength > 0)
            {
                Conexao db = new Conexao();
                db.Conectar();

                UsuarioBanco titular = new UsuarioBanco();
                titular.Titular = textBoxUsuario.Text;
                titular.Senha = textBoxSenha.Text;

                var retorno = db.AlterarSenha(titular.Titular, titular.Senha);
                if (retorno)
                    MessageBox.Show("Senha alterada com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar senha");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            UsuarioBanco titular = new UsuarioBanco();
            titular.Titular = textBox3.Text;

            var retorno = db.ValidarUsuario(titular.Titular);

            if (!retorno)

            {
                MessageBox.Show("Usuário não existe");
                textBox1.Clear();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
