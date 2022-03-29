using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTT
{
    public partial class InitForm : Form
    {
        public InitForm(string ip)
        {
            InitializeComponent();
            this.Text = ip;
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (tb_ip.Text.Trim() == "")
            {
                MQTTForm mqttForm = new MQTTForm();
                mqttForm.Show();
            }
            else
            {

                MQTTForm mqttForm = new MQTTForm(tb_ip.Text);
                mqttForm.Show();
            }
            
        }
    }
}
