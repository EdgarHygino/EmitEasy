using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitEasy.Models.Interfaces
{
    public  interface IServicoEvento
    {
        public void EnviarEvento(Guid id);
    }
}
