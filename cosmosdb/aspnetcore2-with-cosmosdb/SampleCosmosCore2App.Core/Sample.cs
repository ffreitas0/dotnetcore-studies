using Newtonsoft.Json;
using System;

namespace SampleCosmosCore2App.Core
{
    public class Sample
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string Content { get; set; }
    }
}
