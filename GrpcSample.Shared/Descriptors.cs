using Bond;
using Bond.IO.Safe;
using Bond.Protocols;

namespace GrpcSample.Shared
{
    using Grpc.Core;
    public class Descriptors
    {
        public static Method<Message, Message> Method =
                new Method<Message, Message>(
                    type: MethodType.DuplexStreaming,
                    serviceName: "CustomService",
                    name: "CustomMethod",
                    requestMarshaller: Marshallers.Create(
                        serializer: Serializer<Message>.ToBytes,
                        deserializer: Serializer<Message>.FromBytes),
                    responseMarshaller: Marshallers.Create(
                        serializer: Serializer<Message>.ToBytes,
                        deserializer: Serializer<Message>.FromBytes));
    }
}