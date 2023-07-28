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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text.Length > 0 && textBox1.Text.Length > 0)
            {
                Conexao db = new Conexao();
                db.Conectar();

                Titular titular = new Titular();

                titular.Nome = textBox1.Text;
                titular.Idade = int.Parse(textBox2.Text);
                titular.Email = textBox3.Text;
                titular.DataNascimento = DateTime.Parse(textBox4.Text);
                titular.Usuario = textBox5.Text;
                titular.Senha = textBox6.Text;


                var retorno = db.InserirTitular(titular);

                MessageBox.Show(retorno);

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Informe todos os dados do titular para cadastrar");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void LimparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }
    }
}
