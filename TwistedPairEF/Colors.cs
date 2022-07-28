using Newtonsoft.Json;
using System.Collections.Generic;

namespace TwistedPairEF
{
    public class Colors
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("pairNumber")]
        public int PairNumber { get; set; }

        [JsonProperty("firstColor")]
        public string? FirstColor { get; set; }

        [JsonProperty("secondColor")]
        public string? SecondColor { get; set; }

        [JsonProperty("firstBinderColor")]
        public string? FirstBinderColor { get; set; }

        [JsonProperty("secondBinderColor")]
        public string? SecondBinderColor { get; set; }
    }

}
