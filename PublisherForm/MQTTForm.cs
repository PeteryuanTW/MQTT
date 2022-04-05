using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Receiving;
using MQTTnet.Client.Options;

namespace MQTT
{
    public partial class MQTTForm : Form
    {
        MqttFactory mqttFactory = new MqttFactory();
        IMqttClient client;
        private string ip;
        public MQTTForm(string ip)
        {
            InitializeComponent();
            this.ip = ip;
        }

        private void FormLoad(object sender, EventArgs eventArgs)
        {

            var task = Task.Run(async () => await Connect(false));

        }
        private void FormClose(object sender, FormClosingEventArgs eventArgs)
        {
            var task = Task.Run(async () => await client.DisconnectAsync());
        }
        private async Task Connect(bool subscribe)
        {
            try
            {
                client = mqttFactory.CreateMqttClient();
                string id = Guid.NewGuid().ToString();
                var option = new MqttClientOptionsBuilder()
                    .WithClientId(id)
                    .WithTcpServer(ip, 1883)
                    .WithCleanSession()
                    .Build();
                SetHeaderID(id+"<--->"+ip);
                client.UseConnectedHandler(e =>
                {
                    ConnectStatus(true);
                });

                client.UseDisconnectedHandler(e =>
                {
                    ConnectStatus(false);
                });
                await client.ConnectAsync(option);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            
            
        }
        #region Click
        private void SubscribeClick(object sender, EventArgs e)
        {
            var task = Task.Run(async () => await Subscribe());
        }

        private void PublishClick(object sender, EventArgs e)
        {
            var task = Task.Run(async () => await Publish());
        }


        private async Task Subscribe()
        {
            if (tb_subscribeTopic.Text == "")
            {
                SetLabel(L_subscribeStatus, false);

                return;
            }
            var topicFilter = new MqttTopicFilterBuilder()
                .WithTopic(tb_subscribeTopic.Text)
                .Build();

            await client.SubscribeAsync(topicFilter);
            SetLabel(L_subscribeStatus, true);
            ClearContent();

            client.UseApplicationMessageReceivedHandler(e =>
            {
                ShowContent(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
            });

        }

        private async Task Publish()
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(tb_publishTopic.Text)
                .WithPayload(tb_publishContent.Text)
                .WithRetainFlag(true)
                .WithQualityOfServiceLevel(1)
                .WithAtLeastOnceQoS()
                .Build();
            if (client.IsConnected)
            {
                await client.PublishAsync(message);
            }

        }
        #endregion

        #region UI
        private void SetLabel(Label label, bool flag)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() =>
                {
                    label.BackColor = flag ? Color.GreenYellow : Color.Red;
                    label.Text = flag ? "success" : "fail";
                }));
            }
            else
            {
                label.BackColor = flag ? Color.GreenYellow : Color.Red;
                label.Text = flag ? "success" : "fail";
            }
        }

        private void ConnectStatus(bool flag)
        {
            if (L_connect.InvokeRequired)
            {
                L_connect.Invoke(new Action(() =>
                {
                    L_connect.BackColor = flag ? Color.GreenYellow : Color.DimGray;
                    tb_subscribeTopic.Enabled = flag;
                    tb_publishTopic.Enabled = flag;
                    tb_publishContent.Enabled = flag;
                    btn_subscribe.Enabled = flag;
                    btn_publish.Enabled = flag;
                }));
            }
            else
            {
                L_connect.BackColor = flag ? Color.GreenYellow : Color.DimGray;
                tb_subscribeTopic.Enabled = flag;
                tb_publishTopic.Enabled = flag;
                tb_publishContent.Enabled = flag;
                btn_subscribe.Enabled = flag;
                btn_publish.Enabled = flag;
            }
        }

        private void ShowContent(string newText)
        {
            if (tb_content.InvokeRequired)
            {
                tb_content.Invoke(new Action(() =>
                {
                    if (tb_content.Text.Length == 0)
                    {
                        tb_content.Text = newText;
                    }
                    else
                    {
                        tb_content.AppendText("\r\n" + newText);
                    }
                }));
            }

            else
            {
                if (tb_content.Text.Length == 0)
                {
                    tb_content.Text = newText;
                }
                else
                {
                    tb_content.AppendText("\r\n" + newText);
                }
            }
        }

        private void ClearContent()
        {
            if (tb_content.InvokeRequired)
            {
                tb_content.Invoke(new Action(() =>
                {
                    tb_content.Text = "";
                }));
            }
            else
            {
                tb_content.Text = "";
            }
        }

        private void SetHeaderID(string id)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.Text = id;
                }));
            }
            else
            {
                this.Text = id;
            }
        }
        
        #endregion
    }
}
