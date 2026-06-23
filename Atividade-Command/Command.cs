using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Command
{
    internal interface Command
    {
        object Execute(object arg);
    }
}
