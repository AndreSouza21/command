using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Command
{
    internal class Pessoa
    {
        private int id;
        private string nome;

        public Pessoa(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int GetPessoaId()
        {
            return id;
        }
        public string GetPessoaNome()
        {
            return nome;
        }


    }
}
