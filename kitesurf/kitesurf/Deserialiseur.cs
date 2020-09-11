using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitesurf
{
    class Deserialiseur
    {
        jsonStr = "ça va mon reuf";
        
            public string Title { get; set; }
            public string Content { get; set; }
            public string Url { get; set; }
            public string serealize { get; set; }

        // read file into a string and deserialize JSON to a type
        Movie movie1 = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(@"c:\movie.json"));

        // deserialize JSON directly from a file
        using (StreamReader file = File.OpenText(@"c:\movie.json"))
        {
            JsonSerializer serializer = new JsonSerializer();
            Movie movie2 = (Movie)serializer.Deserialize(file, typeof(Movie));
        }
}
