using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyForecast
{
    public class Fec
    {
        public string nome_fec { get; set; }
        public int fec_id { get; set; }
    }

    public class ParametriNumericiFec
    {
      
        public string nome_campo { get; set; }
        public string[] valore_campo { get; set; }
    }

    public class ParametriStringaFec
    {
        public string nome_campo { get; set; }
        public string[] valore_campo { get; set; }
    }

    public class ParametriNumericiFmlFec
    {
        public string nome_campo { get; set; }
        public string valore_campo { get; set; }
    }
    


    public class MasterRootObejct
        {

        public string fecName { get; set; }
        public string fecId { get; set; }
        public List<ParametriNumericiFec> ParametriNumericiFec { get; set; }
        public List<ParametriStringaFec>ParametriStringaFec {get;set;}
        public List<ParametriStringaFec> ParametriDataFec { get; set; }
        public List<ParametriNumericiFmlFec> ParametriNumericiFmlFec { get; set; }
        public List<ParametriNumericiFmlFec> ParametriStringaFmlFec { get; set; }
   }
}
