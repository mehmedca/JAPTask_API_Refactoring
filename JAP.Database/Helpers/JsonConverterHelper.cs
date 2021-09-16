using JAP.Core.Entities;
using JAP.Database.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JAP.Database.Helpers
{
    public class JsonConverterHelper
    {
        //Load json data from file then deserialize it to desired object type arrays
        public static List<T> LoadJsonFromFile<T>(string fileName)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var itemData = File.ReadAllText("C:/Users/mehmedca/Desktop/JAP/jap projects/JAP_Task_2/JAP_Task_2_API/JAP.Database/SeedJson/" + fileName);
            var items = JsonSerializer.Deserialize<List<T>>(itemData, options);
            
            return items;
        }
    }
}
