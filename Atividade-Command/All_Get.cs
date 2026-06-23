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

        public void AllCommand(DataBase db) { this.db = db; }

        public object Execute(object obj)
        {
            db.ShowAll();
            return null;
        }
    }

    internal class Get : Command
    {
        private DataBase db;

        public void GetCommand(DataBase db) { this.db = db; }

        public object Execute(object obj)
        {
            int id = (int)obj;
            return db.Buscar(id);
        }
    }
}
