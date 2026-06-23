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
            if (arg is ValueTuple<string, int> dados)
            {
                string nome = dados.Item1;
                int id = dados.Item2;

                db.Inserir(id, nome);

                
            }


            return null;
        }
    }
}
