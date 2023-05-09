using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameNetCource.Net
{
    
    
    public class TCPMessageManager
    {
        // кодирование экземпляра
        public static string CodingAsync(Player source)
        {
            string jsonString = JsonSerializer.Serialize(source);
            return jsonString;
        }
        // декодирование экземпляра
        public static Player Decoding(string code)
        {
            string msg = code.Substring(code.IndexOf("{"));
            return JsonSerializer.Deserialize<Player>(msg);
        }
    }
}
