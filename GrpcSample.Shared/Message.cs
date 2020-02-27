using FlatSharp.Attributes;

namespace GrpcSample.Shared
{
    [FlatBufferTable]
    public class Message
    {
        [FlatBufferItem(0)]
        public virtual string Text { get; set; }
    }
}