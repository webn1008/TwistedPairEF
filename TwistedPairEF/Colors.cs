using Newtonsoft.Json;
using System.Collections.Generic;
using TwistedPairEF.Models;

namespace TwistedPairEF
{
    public class Colors: PairModel
    {
        [JsonProperty("id")]
        public new int Id { get; set; }

        [JsonProperty("pairNumber")]
        public new int PairNumber { get; set; }

        [JsonProperty("firstColor")]
        public new string? FirstColor { get; set; }

        [JsonProperty("secondColor")]
        public new string? SecondColor { get; set; }

        [JsonProperty("firstBinderColor")]
        public new string? FirstBinderColor { get; set; }

        [JsonProperty("secondBinderColor")]
        public new string? SecondBinderColor { get; set; }
    }

}
