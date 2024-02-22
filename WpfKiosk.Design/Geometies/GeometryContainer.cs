
using System.IO;
using System.Reflection;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace WpfKiosk.Design.Geometies;

public static class GeometryContainer
{
    internal static GeometryRoot _data;
    internal static Dictionary<string, GeometryItem> _items;

    static GeometryContainer()
    {
        Build();
    }

    private static void Build()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        var resourceName = "WpfKiosk.Design.Properties.Resources.geometries.yaml";

        using(Stream stream = assembly.GetManifestResourceStream(resourceName))
        using(StreamReader reader = new StreamReader(stream))
        {
            StringReader sr = new StringReader(reader.ReadToEnd());
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            _data = deserializer.Deserialize<GeometryRoot>(sr);

            _items = new Dictionary<string, GeometryItem>();
            foreach( GeometryItem item in _data.Geometries )
            {
                _items.Add(item.Name, item);
            }
        }
    }
}
