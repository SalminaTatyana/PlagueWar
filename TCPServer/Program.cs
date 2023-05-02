using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using TCPServer;
using TCPServer.IO;
class Program
{
    static List<Client> _users;
    static TcpListener _listener;
    static async Task Main(string[] args)
    {
        _users = new List<Client>();
        Connection connection = await Connection();
        _listener = new TcpListener(IPAddress.Any, connection.port);
        _listener.Start();

        while (true)
        {
            
            if (_users.Count<2)
            {
                var client = new Client(_listener.AcceptTcpClient());
                _users.Add(client);
                BroadcastConnection();
            }
        }
    }
    static async Task<Connection> Connection()
    {
        string ip = "";
        IPAddress ipParce ;
        int port = 55556;
        string portStr = "";

        try
        {


            while (!IPAddress.TryParse(ip, out ipParce) || ip.Length<8)
            {
                Console.Write("ip:");
                ip = Console.ReadLine();
            }
            
            while (!Int32.TryParse(portStr,out port)|| portStr.Length>5|| portStr.Length<4||port> 65535)
            {

                Console.Write("port:");
                portStr = Console.ReadLine();
            }

        }
        catch (Exception ex)
        {
        }
        return new Connection(ip, port);
    }
    static void BroadcastConnection()
    {
        foreach (var user in _users)
        {
            foreach (var usr in _users)
            {
                var broadcastPacket = new PacketBuilder();
                broadcastPacket.WriteMessage(usr.Username);
                broadcastPacket.WriteMessage(usr.UID.ToString());
                user.ClientSocet.Client.Send(broadcastPacket.GetPacketBytes());
            }
        }
    }

    public static void BroadcastMessage(string message)
    {
        foreach (var user in _users)
        {
            var msgPacket = new PacketBuilder();
            msgPacket.WriteOpCode(5);
            msgPacket.WriteMessage(message);
            user.ClientSocet.Client.Send(msgPacket.GetPacketBytes());
        }
    }
    public static void BroadcastDisconnect(string uid)
    {
        var disconnectedUser = _users.Where(x => x.UID.ToString() == uid).FirstOrDefault();
        _users.Remove(disconnectedUser);
        foreach (var user in _users)
        {
            var broadcastPacket = new PacketBuilder();
            broadcastPacket.WriteOpCode(10);
            broadcastPacket.WriteMessage(uid);
            user.ClientSocet.Client.Send(broadcastPacket.GetPacketBytes());
        }
        BroadcastMessage($"{disconnectedUser.Username} отключен.");
    }
}
