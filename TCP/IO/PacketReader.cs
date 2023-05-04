using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP.IO
{
    public class PacketReader : BinaryReader
    {
        private NetworkStream _ns;
        public PacketReader(NetworkStream ns) : base(ns)
        {
            _ns = ns;
        }
        public string ReadMessage()
        {
            byte[] msgBuffer;
            var length = ReadInt32();
            msgBuffer = new byte[length];
            _ns.Read(msgBuffer, 0, length);
            //вот тут сделать декодировку данных tcpmessage
            var msg = Encoding.UTF8.GetString(msgBuffer);
            return msg;
        }
    }
}
