using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace xml_to_json
{
    public class JsonFilter
    {
        public static string FilterJsonFields(string jsonString, List<string> fieldsToKeep)
        {
            try

            {
                JToken jsonToken = JToken.Parse(jsonString);

                if (jsonToken is JArray jsonArray)
                {
                    JArray filteredJsonArray = new JArray();

                    foreach (JObject jsonPerson in jsonArray)
                    {
                        JObject filteredPerson = new JObject();

                        foreach (string field in fieldsToKeep)
                        {
                            if (jsonPerson.TryGetValue(field, out JToken value))
                            {
                                filteredPerson.Add(field, value);
                            }
                        }

                        filteredJsonArray.Add(filteredPerson);
                    }

                    return filteredJsonArray.ToString();
                }
                else if (jsonToken is JObject jsonObject)
                {
                    JObject filteredJsonObject = new JObject();

                    foreach (string field in fieldsToKeep)
                    {
                        if (jsonObject.TryGetValue(field, out JToken value))
                        {
                            filteredJsonObject.Add(field, value);
                        }
                    }

                    return filteredJsonObject.ToString();
                }
                else
                {
                    // Handle other cases or throw an exception as needed
                    throw new InvalidOperationException("Invalid JSON format");
                }
            }
            catch (JsonReaderException ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
                return jsonString; // Return the input string as-is in case of a parsing error
            }
        }



    }
}
