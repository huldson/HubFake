using hub.domain.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Diagnostics.CodeAnalysis;

namespace hub.aplication.Service
{
    public class Metodos : IMetodos
    {
        public string Name()
        {
            StackTrace stackTrace = new StackTrace();

            // Obtém o método atual na pilha de chamadas de métodos
            MethodBase method = stackTrace.GetFrame(2).GetMethod();
                 
            // Obtém o nome do método atual
            string methodName = method.Name;
            return methodName;

        }
    }
}
