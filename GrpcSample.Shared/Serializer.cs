using System;
using Bond;
using Bond.IO.Unsafe;
using Bond.Protocols;
using FlatSharp;
using InputBuffer = Bond.IO.Unsafe.InputBuffer;

namespace GrpcSample.Shared
{
    public static class Serializer<T> where T:class
    {
        public static byte[] ToBytes(T obj) 
        {

            int maxBytesNeeded = FlatBufferSerializer.Default.GetMaxSize(obj);
            byte[] buffer = new byte[maxBytesNeeded];
            int bytesWritten = FlatBufferSerializer.Default.Serialize(obj, buffer);
            return buffer;
        
          
        }

        public static T FromBytes(byte[] bytes)
        {
            return FlatBufferSerializer.Default.Parse<T>(bytes);
          
        }
    }
}