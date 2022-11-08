using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_wins_form_aula
{
    internal class Jogador
    {
        public string nome { get; set; }
        public string email { get; set; }

        public Jogador(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
    }
}
