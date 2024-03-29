﻿using Newtonsoft.Json;

namespace WpfKiosk.Design.Images;

internal class ImageRoot
{
    [JsonProperty("images")]
    public List<ImageItem> Items { get; set; }
}
