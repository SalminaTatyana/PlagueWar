using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TCP.IO;

namespace TCP
{
    public class Client
    {
        public string Username { get; set; }
        public Guid UID { get; set; }
        public TcpClient ClientSocet { get; set; }
        PacketReader _packetReader;
        public Client(TcpClient client)
        {
            ClientSocet = client;
            UID = Guid.NewGuid();
            _packetReader = new PacketReader(ClientSocet.GetStream());
            var opcode = _packetReader.ReadByte();
            Username = _packetReader.ReadMessage();
            Form1.Write($"[{DateTime.Now}] : Пользователь {Username} подключен.");

            Task.Run(() => Process());
        }
        void Process()
        {
            while (true)
            {
                try
                {
                    var opcode = _packetReader.ReadByte();
                    switch (opcode)
                    {
                        case 5:
                            var msg = _packetReader.ReadMessage();
                            Form1.BroadcastMessage($"{Username} : {msg}");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Form1.Write($"[{DateTime.Now}] : Пользователь {Username} отключен.");
                    Form1.BroadcastDisconnect(UID.ToString());
                    ClientSocet.Close();
                    break;
                }
            }
        }
    }
}
