using Newtonsoft.Json;

namespace SystemExpert.Model
{
    public class DiseaseData
    {
        [JsonProperty("связь")]
        public Dictionary<string, List<string>> Symptoms { get; set; }
    }
}
