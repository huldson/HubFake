using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hub.infrastructure
{
    public class LogResgistro 
    {
        
       
        public string Metodo { get; set; }
        public string Url { get; set; }
        public string Codestatus { get; set; }

        public LogResgistro() { }
        
        public LogResgistro(string metodo,string url,string codeStatus ) {
            Metodo= metodo;
            Url= url;   
            Codestatus= codeStatus;
        
        
        }


    }
}
