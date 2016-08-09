
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EasyForecast.SymEngine.Json
{
   public class Program
    {
        
        static void Main(string[] args)
        {

            /// initialize Json Input Objects

            InputClass.JsonInputClass inputJsonFec = new InputClass.JsonInputClass();

            inputJsonFec.FECs = new List<InputClass.FEC>
                  {
                    new InputClass.FEC
                     {
                        FecId=1,
                        FecName = "FecNameXYZ",

                        OrderedParameterNames = new List<string>
                        { "NumArrayNameXYZ1", "StrArrayNameXYZ1","NumArrayNameXYZ2", "...and other parameter names..."},

                        NumParameters = new List<InputClass.NumParameter>
                        {
                           new InputClass.NumParameter {ArrayName="NumArrayNameXYZ1",ArrayContent = new List<int> {1,2,3,4,5} },
                           new InputClass.NumParameter {ArrayName="NumArrayNameXYZ2",ArrayContent = new List<int> {10,11,12} },
                           new InputClass.NumParameter {ArrayName = "NumArrayNameXYZ3",ArrayContent = new List<int> {7,8,9} }
                        },

                       StrParameters= new List<InputClass.StrParameter>
                        {
                           new InputClass.StrParameter {ArrayName="StrArrayNameXYZ1",ArrayContent = new List<string> {"a","b","c" } },
                           new InputClass.StrParameter {ArrayName="StrArrayNameXYZ2",ArrayContent = new List<string> {"a","b","c" } },
                           new InputClass.StrParameter {ArrayName="StrArrayNameXYZ3",ArrayContent = new List<string> {"a","b","c" } }
                        },

                       DateParameters = new List<InputClass.DateParameter>
                        {
                           new InputClass.DateParameter {ArrayName="DateArrayNameXYZ1",ArrayContent = new List<string> {"16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945"}},
                           new InputClass.DateParameter {ArrayName="DateArrayNameXYZ2",ArrayContent = new List<string> {"16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945"}},
                           new InputClass.DateParameter {ArrayName="DateArrayNameXYZ3",ArrayContent = new List<string> {"16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945"}}
                        },

                       FmlNumParameters = new List<InputClass.FmlNumParameter>
                        {
                            new InputClass.FmlNumParameter {ArrayName="FmlNumArrayNameXYZ1",ArrayContent=new List<int> {1,2,3} },
                            new InputClass.FmlNumParameter {ArrayName="FmlNumArrayNameXYZ2",ArrayContent=new List<int> {1,2,3} },
                            new InputClass.FmlNumParameter {ArrayName="FmlNumArrayNameXYZ3",ArrayContent=new List<int> {1,2,3} }
                        },

                       FmlStrParameters = new List<InputClass.FmlStrParameter>
                        {
                            new InputClass.FmlStrParameter {ArrayName="FmlStrArrayNameXYZ1",ArrayContent= new List<string> {"a","b","c" } },
                            new InputClass.FmlStrParameter {ArrayName="FmlStrArrayNameXYZ2",ArrayContent= new List<string> {"a","b","c" } },
                            new InputClass.FmlStrParameter {ArrayName="FmlStrArrayNameXYZ3",ArrayContent= new List<string> {"a","b","c" } }
                        },

                       FmlDateParameters = new List<InputClass.FmlDateParameter>
                        {
                            new InputClass.FmlDateParameter {ArrayName="FmlDateArrayNameXYZ1",ArrayContent= new List<string> { "16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945" } },
                            new InputClass.FmlDateParameter {ArrayName="FmlDateArrayNameXYZ2",ArrayContent= new List<string> { "16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945" } },
                            new InputClass.FmlDateParameter {ArrayName="FmlDateArrayNameXYZ3",ArrayContent= new List<string> { "16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945" } }
                        }

            }

       };

            string jsonResult = JsonConvert.SerializeObject(inputJsonFec);
            JToken Jtokeninput = JObject.Parse(jsonResult);

           
            /// initialize Json output Objects
            
            OutputClass.JsonOutputClass outputJsonFec = new OutputClass.JsonOutputClass();

            outputJsonFec.Tables = new List<OutputClass.Table>
                  {
                    new OutputClass.Table
                      {
                        TableId=1,
                        TableName = "FecNameXYZ",

                        OrderedColumnNames = new List<string>
                          { "NumColumnNameXYZ1", "StrColumnNameXYZ1", "NumColumnNameXYZ2", "...and other column names..."},

                        NumColumns = new List<OutputClass.NumColumn>
                        {
                            new OutputClass.NumColumn {ColumnName="NumColumnNameXYZ1",ColumnContent = new List<int> {6,7,8,9,0} },
                            new OutputClass.NumColumn {ColumnName="NumColumnNameXYZ2",ColumnContent = new List<int> {1,2,3,8} },
                            new OutputClass.NumColumn {ColumnName="NumColumnNameXYZ3",ColumnContent = new List<int> {1,2,3} }
                        },

                       StrColumns= new List<OutputClass.StrColumn>
                       {
                           new OutputClass.StrColumn {ColumnName="StrColumnNameXYZ1",ColumnContent = new List<string> {"a","b","c" } },
                           new OutputClass.StrColumn {ColumnName="StrColumnNameXYZ2",ColumnContent = new List<string> {"a","b","c" } },
                           new OutputClass.StrColumn {ColumnName="StrColumnNameXYZ3",ColumnContent = new List<string> {"a","b","c" } }
                       },

                       DateColumns = new List<OutputClass.DateColumn>
                        {
                           new OutputClass.DateColumn {ColumnName="DateColumnNameXYZ1",ColumnContent = new List<string> {"16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945"}},
                           new OutputClass.DateColumn {ColumnName="DateColumnNameXYZ2",ColumnContent = new List<string> {"16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945"}},
                           new OutputClass.DateColumn {ColumnName="DateColumnNameXYZ3",ColumnContent = new List<string> {"16/09/1977", "23/2/1952", "18/6/1982", "5/12/1945"}}
                        }
               }
        };

             jsonResult = JsonConvert.SerializeObject(outputJsonFec, Formatting.Indented);
             JToken JtokenOutput = JObject.Parse(jsonResult);


            /////////////////////////////


            /// takes input params from cmd
            JsonOutput jOutput = new JsonOutput();
            Console.WriteLine("####################**JSON_RANDOM**####################\n");
            Console.WriteLine("Reading Json Input File...\n\n");
            string input = "";
            string inputArrayName = "";
            string inputColumnName = "";

            while(input!= "q")
            {
                Console.WriteLine("Which Array field do you wanna shuffle?\n");
                Console.WriteLine("<> Press 'a' to select the field named 'NumArrayNameXYZ1'\n");
                Console.WriteLine("<> Press 'b' to select the field named 'NumArrayNameXYZ2'\n");
                Console.WriteLine("<> Press 'c' to select the field named 'NumArrayNameXYZ3'\n");

                while (input != "a" && input != "b" && input != "c")
                {
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "a":
                            inputArrayName = jOutput.NumArrayNameXYZ1;
                            break;
                        case "b":
                            inputArrayName = jOutput.NumArrayNameXYZ2;
                            break;
                        case "c":
                            inputArrayName = jOutput.NumArrayNameXYZ3;
                            break;
                        case "q":
                            Console.WriteLine("Quit Program\n");
                            break;
                        default:
                            Console.WriteLine("wrong command,try again\n");
                            break;

                    }
                }
                Console.WriteLine("\nNow select where do you wanna copy those shuffled values\n");
                Console.WriteLine("Press 'd' to select the field named 'NumColumnNameXYZ1'\n");
                Console.WriteLine("Press 'e' to select the field named 'NumColumnNameXYZ2'\n");
                Console.WriteLine("Press 'f' to select the field named 'NumColumnNameXYZ3'\n");

                while (input != "d" && input != "e" && input != "f")
                {
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "d":
                            inputColumnName = jOutput.NumColumnNameXYZ1;
                            break;
                        case "e":
                            inputColumnName = jOutput.NumColumnNameXYZ2;
                            break;
                        case "f":
                            inputColumnName = jOutput.NumColumnNameXYZ3;
                            break;
                        case "q":
                            Console.WriteLine("Quit Program");
                            break;
                        default:
                            Console.WriteLine("wrong command,try again\n");
                            break;

                    }
                }

                Console.WriteLine("Here comes the Output\n");
                string jsonOutput = jOutput.Jreplace(Jtokeninput,inputArrayName, inputColumnName,JtokenOutput);
                Console.WriteLine(jsonOutput);
                Console.ReadLine();
            }

            /* JsonOutput jOutput = new JsonOutput();
               string numArrayNameXYZ1 = jOutput.NumArrayNameXYZ1;
               string numArrayNameXYZ2 = jOutput.NumArrayNameXYZ2;
               string numArrayNameXYZ3 = jOutput.NumArrayNameXYZ3;

               string numColumnNameXYZ1 = jOutput.NumColumnNameXYZ1;
               string numColumnNameXYZ2 = jOutput.NumColumnNameXYZ2;
               string numColumnNameXYZ3 = jOutput.NumColumnNameXYZ3;

               string jsonOutput = jOutput.Jreplace( Jtokeninput,inputArrayName, inputColumnName,JtokenOutput);

               ///prints the output JSON with changed values
               Console.WriteLine(jsonOutput);
               Console.ReadLine();
            */

        }
    }       
}       
