using Newtonsoft.Json;

namespace WpfKiosk.Design.Geometies;

internal class GeometryRoot
{
    [JsonProperty("geometries")]
    public List<GeometryItem> Items { get; set; }
}
