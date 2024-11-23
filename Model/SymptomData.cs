using Newtonsoft.Json;

namespace SystemExpert.Model
{
    public class SymptomData
    {
        [JsonProperty("симптомы")]
        public List<string> Symptoms { get; set; }
    }

}
