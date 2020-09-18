using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace kitesurf
{
    class Deserialiseur
    {
        public void DeserialiseurM(string jsonStr)
        {


                public string Title { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string serealize { get; set; }

        // read file into a string and deserialize JSON to a type
        dynamic movie1 = JsonConvert.DeserializeObject<dynamic>(jsonStr);

            // deserialize JSON directly from a file

            using (StreamReader file = File.OpenText(@"c:\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Movie movie2 = (Movie)serializer.Deserialize(file, typeof(Movie));
            }
        }
    }
}
