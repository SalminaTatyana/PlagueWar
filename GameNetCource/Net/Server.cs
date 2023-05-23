using GameNetCource.Net.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameNetCource.Net
{
    public class Server
    {
        public TcpClient _client;
        public PacketReader PacketReader;
        public event Action connectedEvent;
        public event Action startGameEvent;
        public event Action startGameOfAnoutherPlayerEvent;
        public event Action msgReceivedEvent;
        public event Action disconnectedEvent;
        public Server()
        {
            _client = new TcpClient();
        }
        public async Task ConnectToServerAsync(string username, string ip, int port)
        {
            if (!_client.Connected)
            {

                try
                {
                    if (String.IsNullOrEmpty(ip))
                    {
                        ip = "127.0.0.1";

                    }
                    if (port == 0)
                    {

                        port = 55555;
                    }
                    _client.Connect(ip, port);
                    PacketReader = new PacketReader(_client.GetStream());
                    if (!string.IsNullOrEmpty(username))
                    {
                        var connectPacket = new PacketBuilder();
                        connectPacket.WriteOpCode(0);
                        connectPacket.WriteMessage(username);
                        _client.Client.Send(connectPacket.GetPacketBytes());
                    }
                    ReadPackets();
                }
                catch (Exception ex)
                {
                }
                

            }

        }
        public async Task DisonnectToServerAsync()
        {
            if (_client.Connected)
            {
                _client.GetStream().Close();
                _client.Close();
            }

        }
        private void ReadPackets()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        var opcode = PacketReader.ReadByte();
                        switch (opcode)
                        {
                            case 1:
                                connectedEvent?.Invoke();
                                break;
                            case 5:
                                msgReceivedEvent?.Invoke();
                                break;
                            case 6:
                                startGameEvent?.Invoke();
                                break;
                            case 7:
                                startGameOfAnoutherPlayerEvent?.Invoke();
                                break;
                            case 10:
                                disconnectedEvent?.Invoke();
                                break;
                            default:
                                Console.WriteLine("Ah yes...");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {

                    }



                }
            });
        }

        public void SendMessageToServer(string message)
        {
            var messagePacket = new PacketBuilder();
            messagePacket.WriteOpCode(5);
            messagePacket.WriteMessage(message);
            _client.Client.Send(messagePacket.GetPacketBytes());
        }
    }
}
