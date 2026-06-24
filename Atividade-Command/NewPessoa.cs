using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Command
{
    internal class NewPessoa : Command
    {
        DataBase db;
        public NewPessoa(DataBase db) 
        {
            this.db = db;
        }

        public object Execute(object arg)
        {
            string[] args = (string[])arg;

            int id = int.Parse(args[0]);
            string nome = string.Join(" ", args.Skip(1));

            db.Inserir(id, nome);

            return null;
        }
    }
}
