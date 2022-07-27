using Newtonsoft.Json;
using System.Collections.Generic;

namespace TwistedPairEF
{
    public class Colors
    {
        [JsonProperty("id")]
        public List<string> id { get; set; }

        [JsonProperty("pairNumber")]
        public List<string> PairNumber { get; set; }

        [JsonProperty("firstColor")]
        public List<string> FirstColor { get; set; }

        [JsonProperty("secondColor")]
        public List<string> SecondColor { get; set; }

        [JsonProperty("firstBinderColor")]
        public List<string> FirstBinderColor { get; set; }
    }

}
