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
            if (arg is int id)
            {
                db.Remover(id);
            }
            return null;
        }



    }
}
