using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Command
{
    internal class All : Command
    {
        private DataBase db;

        public All(DataBase db) { this.db = db; }

        public object Execute(object obj)
        {
            db.ShowAll();
            return null;
        }
    }

    internal class Get : Command
    {
        private DataBase db;

        public Get(DataBase db) { this.db = db; }

        public object Execute(object obj)
        {
            string[] args = (string[])obj;
            int id = int.Parse(args[0]);

            return db.Buscar(id);
        }
    }
}
