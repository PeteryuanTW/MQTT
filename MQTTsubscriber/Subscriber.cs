using System;
using System.Text;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;

namespace MQTTsubscriber
{
    class Subscriber
    {
        static async Task Main(string[] args)
        {
            MqttFactory mqttFactory = new MqttFactory();
            IMqttClient client = mqttFactory.CreateMqttClient();
            var option = new MqttClientOptionsBuilder()
                .WithClientId(Guid.NewGuid().ToString())
                .WithTcpServer("test.mosquitto.org", 1883)
                .WithCleanSession()
                .Build();

            client.UseConnectedHandler(async e =>
            {
                Console.WriteLine("Connect successful");

                var topicFilter = new MqttTopicFilterBuilder()
                .WithTopic("A")
                .Build();

                await client.SubscribeAsync(topicFilter);
            });

            client.UseDisconnectedHandler(e =>
            {
                Console.WriteLine("Disconnected");
            });

            client.UseApplicationMessageReceivedHandler(e =>
            {
                Console.WriteLine($"receive : {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
            });
            
            
            
            
            
            await client.ConnectAsync(option);

            Console.WriteLine("press a key to publish meaasges");
            Console.ReadLine();

            await client.DisconnectAsync();
        }
    }
}
