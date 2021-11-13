using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Producer
{
    internal class DataJson
    {
        JObject fileName;
        public DataJson(DataBild data)
        {
            this.fileName = (JObject)JToken.FromObject(data);
            //Console.WriteLine(fileName);
        }

        public string BeldJsonDataCondition(string Condition)
        {
            //channel.Property("obsolete").Remove();
            JObject temp = fileName;
            temp.Property(Condition).Remove();
            return temp.ToString();

        }
    }
}
