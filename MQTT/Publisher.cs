using System;

using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;

namespace MQTT
{
    class Publisher
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

            client.UseConnectedHandler(e =>
            {
                Console.WriteLine("Connect successful");
            });

            client.UseDisconnectedHandler(e =>
            {
                Console.WriteLine("Disconnected");
            });

            await client.ConnectAsync(option);

            Console.WriteLine("press a key to publish meaasges");
            Console.ReadLine();

            await PublishMessageAsync(client);

            await client.DisconnectAsync();
        }

        private static async Task PublishMessageAsync(IMqttClient client)
        {
            string messagePayLoad = "Hi!";
            var message = new MqttApplicationMessageBuilder()
                .WithTopic("A")
                .WithPayload(messagePayLoad)
                .WithAtLeastOnceQoS()
                .Build();
            if (client.IsConnected)
            {
                await client.PublishAsync(message);
            }
        }
    }
}
