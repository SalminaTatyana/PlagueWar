using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;




    [Serializable]
    public class TCPMessage
    {
    public Player Player { get; set; }
    public List<Button> Button { get; set; }

}
    public class TCPMessageManager
    {
        // кодирование экземпляра
        public static string CodingAsync(TCPMessage source)
        {
            string jsonString = JsonSerializer.Serialize(source);
            return jsonString;
        }
        // декодирование экземпляра
        public static TCPMessage Decoding(string code)
        {
            return JsonSerializer.Deserialize<TCPMessage>(code);
        }
    }

