using RabbitMQ.Client;
using System;
using System.Text;

namespace Producer
{
    public class Sender
    {
        public static void send(string dataSender)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            using(var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                dataSender = EncryptionAes.Encrypt(dataSender);
                //Console.WriteLine("Encryption_Aes.Encrypt--..{0}", dataSender); // TEST AES
                channel.QueueDeclare("BasicTest", false, false, false, null);
                var body = Encoding.UTF8.GetBytes(dataSender);
                channel.BasicPublish("", "BasicTest", null, body);
            }

        }
    }
}