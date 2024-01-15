using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace oito.Controllers
{
  
    public class ValuesController : Controller
    {
        [HttpGet]
        [Route("api/formatData/FormatData")]
        public ActionResult<string> FormatData(string fields, string values, char delimiter)
        {
            if (string.IsNullOrEmpty(fields) || string.IsNullOrEmpty(values) || delimiter == null)
            {
                return BadRequest("Fields, values, and delimiter are required.");
            }

            string[] fieldArray = fields.Split(',');
            string[] valueArray = values.Split(delimiter);

            // Build a dictionary from the fields and values
            var result = new Dictionary<string, string>();

            for (int i = 0; i < Math.Min(fieldArray.Length, valueArray.Length); i++)
            {
                result[fieldArray[i]] = valueArray[i];
            }

            // Convert the dictionary to a JSON string
            string jsonString = JsonConvert.SerializeObject(result);

            return jsonString;
        }
    }

    }
