using ProjetoIntegrador;
using System.Data;
using System.Data.SqlClient;

namespace WinForms
{
    public class Conexao
    {
        
        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=matheus;Data Source=DESKTOP-UHVFIS7");

        public void Conectar()
        {
            conn.Open();
        }
        public void Desconectar()
        {
            conn.Close();
        }

        public bool BuscarUsuario(string titular, string senha)
        {
            string sql = $"select * from Titular where Usuario = '{titular}' and Senha = '{senha}' ";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
            {
                Desconectar();
                return true;
            }

            return false;

        }

        public bool ValidarUsuario(string titular)
        {
            string sql = $"select * from Titular where Titular = '{titular}' ";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            Desconectar();


            return true;

        }

        public bool AlterarSenha(string titular, string senha)
        {
            string sql = $"Update Titular set Senha = '{senha}' where Usuario = '{titular}' ";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            Desconectar();


            return true;

        }

        public string InserirTitular(Titular titular)
        {
            try
            {
                string sql = $"INSERT INTO Titular (Nome, Idade, Email, DataNascimento, Usuario, Senha) VALUES ('{titular.Nome}', {titular.Idade},'{titular.Email}', '{titular.DataNascimento}', '{titular.Usuario}', '{titular.Senha}')";
                SqlCommand comando = new SqlCommand(sql, conn);

                comando.ExecuteNonQuery();

                Desconectar();

                return "Titular inserido com sucesso!";
            }
            catch (Exception e)
            {
                Desconectar();

                return "Erro ao inserir titular";

            }

        }

        public List<Titular> BuscarTitular()
        {
            string sql = "select * from Titular";
            SqlCommand comando = new SqlCommand(sql, conn);

            List<Titular> titular = new List<Titular>();

            using (var reader = comando.ExecuteReader())
            { //cria um leitor do ADO.Net
                while (reader.Read())
                { //vai lendo cada item do resultado do select
                  //retorna sob demanda cada item encontrado
                    var IdDb = reader.GetInt32(reader.GetOrdinal("Id"));
                    var NomeDb = reader.GetString(reader.GetOrdinal("Nome"));
                    var IdadeDb = reader.GetInt32(reader.GetOrdinal("Idade"));
                    var EmailDb = reader.GetString(reader.GetOrdinal("Email"));
                    var DataNascimentolDb = reader.GetDateTime(reader.GetOrdinal("DataNascimento"));
                    var UsuariolDb = reader.GetString(reader.GetOrdinal("Usuario"));
                    var SenhaDb = reader.GetString(reader.GetOrdinal("Senha"));


                    titular.Add(new Titular()
                    {
                        Id = IdDb,
                        Nome = NomeDb,
                        Idade = IdadeDb,
                        Email = EmailDb,
                        DataNascimento = DataNascimentolDb,
                        Usuario = UsuariolDb,
                        Senha = SenhaDb,

                    });

                }
                return titular;
            }
        }

        public List<Eventos> BuscarEventos()
        {
            string sql = "select * from Eventos";
            SqlCommand comando = new SqlCommand(sql, conn);

            List<Eventos> eventos = new List<Eventos>();

            using (var reader = comando.ExecuteReader())
            { //cria um leitor do ADO.Net
                while (reader.Read())
                { //vai lendo cada item do resultado do select
                  //retorna sob demanda cada item encontrado
                    var IdDb = reader.GetInt32(reader.GetOrdinal("Id"));
                    var Evento1Db = reader.GetString(reader.GetOrdinal("Evento1"));
                    var Evento2Db = reader.GetString(reader.GetOrdinal("Evento2"));
                    var Evento3Db = reader.GetString(reader.GetOrdinal("Evento3"));
                    var Evento4Db = reader.GetString(reader.GetOrdinal("Evento4"));

                    eventos.Add(new Eventos()
                    {
                        Id = IdDb,
                        Evento1 = Evento1Db,
                        Evento2 = Evento2Db,
                        Evento3 = Evento3Db,
                        Evento4 = Evento4Db,
                    });

                }
                return eventos;
            }
        }

        public bool ExcluirTitular(int id)
        {
            string sql = $"delete from Titular where Id = {id} ";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
            {
                Desconectar();
            }

            return true;


        }
    }
}
