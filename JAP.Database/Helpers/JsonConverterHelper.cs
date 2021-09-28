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

            //Be sure to check and reformat the json files location if the relative path doesnt work correctly
            var itemData = File.ReadAllText("../JAP.Database/SeedJson/" + fileName);
            var items = JsonSerializer.Deserialize<List<T>>(itemData, options);

            return items;
        }
    }
}
