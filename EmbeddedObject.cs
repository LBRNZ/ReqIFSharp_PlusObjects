using System.IO;

namespace ReqIFSharp
{
    public class EmbeddedObject
    {
        public string Name { get; set; }
        public MemoryStream ObjectValue { get; set; }
    }
}
