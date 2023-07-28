using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
    public class Titular
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }

    public class Eventos
    {
        public int Id { get; set; }
        public string Evento1 { get; set; }
        public string Evento2 { get; set; }
        public string Evento3 { get; set; }
        public string Evento4 { get; set; }
    }
}
