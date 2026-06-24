using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Command
{
    internal class DataBase
    {
        private Dictionary<int, Pessoa> db = new Dictionary<int, Pessoa>();

        public DataBase() { }

        public void Inserir(int id, string nome)
        {
            if (!db.ContainsKey(id))
            {
                db.Add(id, new Pessoa(id, nome));
            }
            else
            {
                Console.WriteLine("Erro: Este ID já existe.");
            }
        }
        public Pessoa Buscar(int id)
        {
            if (db.TryGetValue(id, out Pessoa pessoa))
            {
                return pessoa;
            }
            return null;
        }

        public bool Remover(int id)
        {
            return db.Remove(id);
        }

        public void ShowAll()
        {
            Console.Write("\n[ ");
            foreach (var item in db)
            {
                Console.Write($"({item.Value.GetPessoaId()} {item.Value.GetPessoaNome()}) ");
            }
            Console.Write("]\n");

        }
    }
}
