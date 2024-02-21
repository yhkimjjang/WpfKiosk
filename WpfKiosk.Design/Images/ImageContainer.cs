using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace WpfKiosk.Design.Images;

public class ImageContainer
{
    internal static ImageRoot _data;
    internal static Dictionary<string, ImageItem> _items;

    static ImageContainer()
    {
        Build();
    }

    private static void Build()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        var resourceName = "WpfKiosk.Design.Resources.images.yaml";

        using(Stream stream = assembly.GetManifestResourceStream(resourceName))
        using( StreamReader reader = new StreamReader(stream))
        {
            StringReader sr = new StringReader(reader.ReadToEnd());
            Deserializer deserializer = new Deserializer();
            _data = deserializer.Deserialize<ImageRoot>(sr);

            _items = new Dictionary<string, ImageItem>();
            foreach(var item in _data.Items)
            {
                _items.Add(item.Name, item);
            }
        }
    }
}
