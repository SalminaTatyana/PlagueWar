using System.Globalization;
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
        Console.WriteLine($"Подключение к {connection.ip}:{connection.port}");
        _listener.Start();

        while (true)
        {
            if (_users.Count<2)
            {
                var client = new Client(_listener.AcceptTcpClient());
                _users.Add(client);
                BroadcastConnection();
                if (_users.Count == 2)
                {
                    BroadcastStartMessage();
                }
            }
            
        }
    }
    static async Task<Connection> Connection()
    {
        string ip = "";
        IPAddress ipParce ;
        int port = 55555;
        int portJson = 55555;
        string portStr = "";
        string ipJson="127.0.0.1";



        try
        {
            try
            {
                using (FileStream fs = new FileStream("appsetting.json", FileMode.OpenOrCreate))
                {
                    Connection connection = await JsonSerializer.DeserializeAsync<Connection>(fs);
                    if (!String.IsNullOrEmpty(connection.ip))
                    {
                        if (String.IsNullOrEmpty(ip))
                        {
                            ipJson = connection.ip;
                        }
                        if (port < 1)
                        {
                            portJson = connection.port;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                
            }
           
            while (!IPAddress.TryParse(ip, out ipParce) || ip.Length<8)
            {
                Console.Write("ip:");
                string ip1 = Console.ReadLine();
                if (ip1.Length>0)
                {
                    ip=ip1.Trim();
                }
                else
                {
                    ip = !String.IsNullOrEmpty(ipJson)? ipJson:"127.0.0.1";
                }
            }
            
            while (!Int32.TryParse(portStr,out port)|| portStr.Length>5|| portStr.Length<4||port> 65535)
            {

                Console.Write("port:");
                    string portStr1 = Console.ReadLine();
                if (portStr1.Length > 0)
                {
                    portStr = portStr1.Trim();
                }
                else
                {
                    portStr = portJson.ToString() ;
                }
                
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
        string userName = message.Substring(0, message.IndexOf(':'));
        foreach (var user in _users)
        {
            if (user.Username!=userName.Trim())
            {
                var msgPacket = new PacketBuilder();
                msgPacket.WriteOpCode(5);
                msgPacket.WriteMessage(message);
                user.ClientSocet.Client.Send(msgPacket.GetPacketBytes());
            }
            
        }
    }  
    public static void BroadcastStartMessage()
    {
        var user = _users[0];
        {
            var msgPacket = new PacketBuilder();
            msgPacket.WriteOpCode(6);
            msgPacket.WriteMessage(_users[1].Username.ToString());
            user.ClientSocet.Client.Send(msgPacket.GetPacketBytes());
        }
        var user2 = _users[1];
        {
            var msgPacket = new PacketBuilder();
            msgPacket.WriteOpCode(7);
            msgPacket.WriteMessage(user.Username.ToString());
            user2.ClientSocet.Client.Send(msgPacket.GetPacketBytes());
        }
    }
    public static void BroadcastEndMessage(string message)
    {
        string userName = message.Substring(0, message.IndexOf(':'));

        foreach (var user in _users)
        {
            if (user.Username != userName.Trim())
            {
                var msgPacket = new PacketBuilder();
                msgPacket.WriteOpCode(8);
                msgPacket.WriteMessage(message);
                user.ClientSocet.Client.Send(msgPacket.GetPacketBytes());
            }

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
    }
}
