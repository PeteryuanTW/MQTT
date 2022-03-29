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
        public InitForm()
        {
            InitializeComponent();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            MQTTForm mqttForm = new MQTTForm(tb_name.Text);
            mqttForm.Show();
        }
    }
}
