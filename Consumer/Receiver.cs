using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Consumer
{
    public class Receiver
    {
        public static void Rec()
        {
            string Data_Receiver = "1";
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            using(var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTest", false, false, false, null);
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    string massage = Encoding.UTF8.GetString(body);
                    massage = AesDecrypt.Decrypt(massage);
                    Data_Receiver = massage;
                    if (Data_Receiver == "2")
                    {
                        Console.WriteLine("Press enter to exit the Receiver app ");
                    }
                    else
                    {
                        Console.WriteLine("Received message {0} ....", massage);
                    }
                };
                Data_Receiver = channel.BasicConsume("BasicTest", true, consumer);
                if (Data_Receiver == "2")
                {
                 Console.WriteLine("Press enter to exit the Receiver app ");
                }
                Console.ReadLine();
            }
        }
    }
}