using System;
using System.Drawing;
using System.IO;

namespace ReqIFSharp
{
    public class EmbeddedObject
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public MemoryStream ObjectValue { get; set; }
        public Bitmap PreviewImage { get; set; }

    }
}
