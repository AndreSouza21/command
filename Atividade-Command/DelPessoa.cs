using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Command
{
    internal class DelPessoa : Command
    {
        DataBase db;
        public DelPessoa(DataBase db)
        {
            this.db = db;
        }

        public object Execute(object arg)
        {
            string[] args = (string[])arg;
            int id = int.Parse(args[0]);

            db.Remover(id);

            return null;
        }



    }
}
