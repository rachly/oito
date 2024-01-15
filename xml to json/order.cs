using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_to_json
{
     public  class order
    {

       public static List<string> SortStrings(string[] inputStrings)
        {
            // Sorting based on length and lexicographically
            List<string> sortedList = inputStrings.OrderBy(s => s.Length)
                                                  .ThenBy(s => s)
                                                  .ToList();

            return sortedList;
        }

    }
}
