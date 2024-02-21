using Newtonsoft.Json;

namespace WpfKiosk.Design.Geometies;

internal class GeometryItem
{
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("data")]
    public string Data { get; set; }
}
