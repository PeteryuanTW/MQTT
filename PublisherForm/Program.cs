﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Server;
using MQTTnet.Client.Receiving;
using System.Text;

namespace MQTT
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            await MqttAsync();
            Application.Run(new InitForm());
        }

        private static async Task MqttAsync()
        {
            var optionsBuilder = new MqttServerOptionsBuilder().WithConnectionBacklog(100).WithDefaultEndpointPort(1883);
            var mqttServer = new MqttFactory().CreateMqttServer();
            await mqttServer.StartAsync(optionsBuilder.Build());

            mqttServer.ApplicationMessageReceivedHandler = new MqttApplicationMessageReceivedHandlerDelegate(e =>
            {
                Console.WriteLine($"{e.ClientId} publish {Encoding.UTF8.GetString(e.ApplicationMessage.Payload ?? new byte[0])} at {e.ApplicationMessage.Topic}");
            });

            mqttServer.ClientConnectedHandler = new MqttServerClientConnectedHandlerDelegate(e =>
            {
                Console.WriteLine($"{e.ClientId} connect！");
            });
            mqttServer.ClientDisconnectedHandler = new MqttServerClientDisconnectedHandlerDelegate(e =>
            {
                Console.WriteLine($"{e.ClientId} disconnect！");
            });
        }
    }
}
