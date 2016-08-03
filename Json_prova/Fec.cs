using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_prova
{
    public class ParametriNumericiFec
    {
       
        public string nome_fec { get; set; }
        public int[] fec_id { get; set; }

        }

    public class ParametriStringaFec
    {
        public string nome_campo { get; set; }
        public String[] valore_campo { get; set; }
    }

    public class ParametriDataFec
    {
        public string nome_campo { get; set; }
        public String[] valore_campo { get; set; }
    }



    public class MasterRootObejct
    {
        public List<ParametriNumericiFec> ParametriNumericiFec { get; set; }
        public List<ParametriStringaFec>ParametriStringaFec {get;set;}
        public List<ParametriDataFec> ParametriDataFec { get; set; }
    }
}
