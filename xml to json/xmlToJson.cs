using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml_to_json
{
    public   class xmlToJson
    {

       public static string ConvertXmlToJson(string xmlFilePath)
        {
            try
            {
                // Read the XML file
                XDocument xDoc = XDocument.Load(xmlFilePath);

                // Convert XML to JSON
                string jsonResult = JsonConvert.SerializeXNode(xDoc, Newtonsoft.Json.Formatting.Indented);

                return jsonResult;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

    }
}
