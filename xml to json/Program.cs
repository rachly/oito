using System;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using xml_to_json;

namespace xml_to_json
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string[] Str = { "oito", "Levi", "oiTAX", "Employee", "language", "Encyclopedia", "Bible", "Hello", "Country", "Company" };
            Console.Write("Enter the list of strings separated by commas: ");
            string input = Console.ReadLine();

            // Split the input string into an array of strings
            string[] Str = input.Split(',');



            List<string> sortedList = order.SortStrings(Str);


            //תרגיל 1 
            //need to send him a path of xml file .

            string xmlFilePath;

            // Check if a command-line argument is provided
            if (args.Length > 0)
            {
                xmlFilePath = args[0];
            }
            else
            {
                // Prompt the user for the XML file path
                Console.Write("Enter the path to the XML file: ");
                xmlFilePath = Console.ReadLine();
            }

            // Call the function to convert XML to JSON
            string jsonResult = xmlToJson.ConvertXmlToJson(xmlFilePath);

            if (jsonResult != null)
            {
                Console.WriteLine(jsonResult);
            }
            else
            {
                Console.WriteLine("Failed to convert XML to JSON.");
            }





            // 2 תרגיל - FilterJsonFields 
            //exmpels to test enter it in the console with out the " " .
            // fieldsToKeep = name , age 
            ////string jsonString = "{\"name\":\"John\", \"age\":30, \"city\":\"New York\"}"; 
            ///string longmultypy=" [{\"name\":\"John\", \"age\":30, \"city\":\"New York\"},{\"name\":\"Jane\", \"age\":25, \"city\":\"Los Angeles\"},{\"name\":\"Bob\", \"age\":40, \"city\":\"Chicago\"}]"

            Console.Write("Enter the fields to keep (comma-separated): ");
            string fieldsInput = Console.ReadLine();
            List<string> fieldsToKeep = new List<string>(fieldsInput.Split(','));

            // Get the JSON string from the user
            Console.Write("Enter the JSON string: ");
            string jsonString = Console.ReadLine();

            jsonString = jsonString.Replace("\\\"", "\"");

            string result = JsonFilter.FilterJsonFields(jsonString, fieldsToKeep);

            Console.WriteLine(result);


            //תרגיל 3 בפרויקט נפרד 





            //תרגיל אחרון 

          

        }

      
     



    }



}


