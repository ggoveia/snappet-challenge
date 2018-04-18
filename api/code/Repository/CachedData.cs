using Newtonsoft.Json;
using SnappetChallenge.Model;
using System.Collections.Generic;
using System.IO;

namespace SnappetChallenge.Repository
{
    public class CachedData
    {
        public static readonly IEnumerable<Exercise> Data = GetJsonFileInformation();

        private static IEnumerable<Exercise> GetJsonFileInformation() {

            using (StreamReader r = new StreamReader("Data\\Informations.json"))
            {
                return JsonConvert.DeserializeObject<IEnumerable<Exercise>>(r.ReadToEnd());
            }

        }
    }
}
