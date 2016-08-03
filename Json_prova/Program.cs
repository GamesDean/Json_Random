
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Script.Serialization;


namespace EasyForecast.SymEngine.Json
{
    class Program
    {
        static void Main(string[] args)
        {

            var fecSer = new MasterRootObejct();

            fecSer.Fec = new Fec
            {
                nome_fec = "first_fec",
                fec_id = 001
            };


            fecSer.ParametriNumericiFec = new List<ParametriNumericiFec>
            {
                new ParametriNumericiFec {nome_campo="num_inner_fec",valore_campo= new int[] {002,003} }
            };
            fecSer.ParametriStringaFec = new List<ParametriStringaFec>
            {
                new ParametriStringaFec {nome_campo="str_inner_fec",valore_campo=new String[] {"n","m","k" } }

            };
            fecSer.ParametriDataFec = new List<ParametriStringaFec>
            {
                new ParametriStringaFec {nome_campo="data_inner_fec",valore_campo=new String[] {"d1","d2","dn" } }
            };
            fecSer.ParametriNumericiFmlFec = new List<ParametriNumericiFmlFec>
            {
                new ParametriNumericiFmlFec {nome_campo="num_fml_inner_fec",valore_campo ="fml_content" }
            };
            fecSer.ParametriStringaFmlFec = new List<ParametriNumericiFmlFec>
            {
                new ParametriNumericiFmlFec {nome_campo="str_fml_inner_fec",valore_campo="fml_content" }
            };

            
            // string fecSrj = JsonConvert.SerializeObject(fecSer);           // serializzo l'oggetto da me creato
            


            

        } 


    public void jReplace(){
          try
            {
                string path = "C:\\Users\\Lorenzo\\Documents\\Visual Studio 2015\\Projects\\Json_prova";
                string json_read = System.IO.File.ReadAllText(path + "\\json_input\\fec.json");       // leggo il json da file
                dynamic fecDrj = JsonConvert.DeserializeObject(json_read);     // deserializzo il file json
             try
                {
                    foreach (var item in fecDrj.fecNumericParams)
                    {
                        string fieldName = item.fieldName;
                        string fieldNameR = fieldName.Replace("num_inner_fec", "numeric_innerFec");
                        fecDrj["fecNumericParams"][0]["fieldName"] = fieldNameR;
                        string outputFec = JsonConvert.SerializeObject(fecDrj, Formatting.Indented);
                        Console.WriteLine(outputFec);
                        Console.ReadLine();
                    }
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException) { };
            }
            catch (JsonReaderException) { };
        }



    }       
}       
