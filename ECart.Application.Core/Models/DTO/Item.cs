using Newtonsoft.Json;
using System;

namespace ECart.Application.Core.Models.DTO
{
    public class Item
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("weight")]
        public double Weight { get; set; }
        [JsonProperty("rate")]
        public double Rate { get; set; }
        [JsonProperty("sourceImage")]
        public string SourceImage { get; set; }
    }
}
