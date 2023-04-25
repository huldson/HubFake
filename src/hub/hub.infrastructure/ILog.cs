using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hub.infrastructure
{
    public interface ILog
    {
        void Regitrar(LogResgistro Log);
    }
}
