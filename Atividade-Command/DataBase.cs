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
        private Dictionary<int, string> db = new Dictionary<int, string>();

        public DataBase() { }

        public void Inserir(int id, string nome)
        {
            if (!db.ContainsKey(id))
            {
                db.Add(id, nome);
            }
            else
            {
                Console.WriteLine("Erro: Este ID já existe.");
            }
        }
        public string Buscar(int id)
        {
            if (db.TryGetValue(id, out string valor))
            {
                return valor;
            }
            return "Não encontrado";
        }

        public bool Remover(int id)
        {
            return db.Remove(id);
        }



    }
}
