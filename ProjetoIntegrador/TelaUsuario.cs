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
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
            TelaUsuario_Load();
        }

        public void TelaUsuario_Load()
        {

            Conexao db = new Conexao();
            db.Conectar();

            var titular = db.BuscarTitular();
            //dataGridView1.DataSource = alunos;

            foreach (var Titular in titular)
            {

                dataGridView1.Rows.Add(
                   Titular.Id,
                    Titular.Nome,
                    Titular.Idade,
                    Titular.Email,
                    Titular.DataNascimento,
                    Titular.Usuario);
            }

            var eventos = db.BuscarEventos();
            //dataGridView1.DataSource = alunos;

            foreach (var Eventos in eventos)
            {

                dataGridView2.Rows.Add(
                   Eventos.Id,
                    Eventos.Evento1,
                    Eventos.Evento2,
                    Eventos.Evento3,
                    Eventos.Evento4);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    var id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                    Conexao db = new Conexao();
                    db.Conectar();

                    var resultado = db.ExcluirTitular(id); //Lembrar de desconectar

                    if (resultado)
                        MessageBox.Show("Titular excluído com sucesso");

                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();

                    TelaUsuario_Load();

                }


            }
            catch (Exception)
            {

                MessageBox.Show("Falha ao excluir Titular");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
