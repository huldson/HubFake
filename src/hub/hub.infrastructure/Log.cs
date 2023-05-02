using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace hub.infrastructure
{
    public class Log : ILog
    {
        public void Regitrar(LogResgistro log)
        {
            StreamWriter escritor = new StreamWriter(@"C:\Users\hulds\Desktop\registro\log.txt");
            string json = JsonConvert.SerializeObject(log);
            escritor.WriteLine(json);
            escritor.Close();
        }
    }
}
