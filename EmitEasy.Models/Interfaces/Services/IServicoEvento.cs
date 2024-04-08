using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitEasy.Models.Interfaces.Services
{
    public interface IServicoEvento
    {
        public void EnviarEvento(Guid id);
    }
}
