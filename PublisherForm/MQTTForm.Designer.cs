
namespace MQTT
{
    partial class MQTTForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.L_subscribeStatus = new System.Windows.Forms.Label();
            this.tb_subscribeTopic = new System.Windows.Forms.TextBox();
            this.tb_publishTopic = new System.Windows.Forms.TextBox();
            this.tb_publishContent = new System.Windows.Forms.TextBox();
            this.btn_subscribe = new System.Windows.Forms.Button();
            this.btn_publish = new System.Windows.Forms.Button();
            this.L_publishStatus = new System.Windows.Forms.Label();
            this.L_connect = new System.Windows.Forms.Label();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 5;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlp.Controls.Add(this.L_subscribeStatus, 3, 1);
            this.tlp.Controls.Add(this.tb_subscribeTopic, 1, 1);
            this.tlp.Controls.Add(this.tb_publishTopic, 1, 3);
            this.tlp.Controls.Add(this.tb_publishContent, 1, 4);
            this.tlp.Controls.Add(this.btn_subscribe, 2, 1);
            this.tlp.Controls.Add(this.btn_publish, 2, 4);
            this.tlp.Controls.Add(this.L_publishStatus, 3, 4);
            this.tlp.Controls.Add(this.L_connect, 0, 0);
            this.tlp.Controls.Add(this.tb_content, 1, 5);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 7;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Size = new System.Drawing.Size(605, 415);
            this.tlp.TabIndex = 0;
            // 
            // L_subscribeStatus
            // 
            this.L_subscribeStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_subscribeStatus.AutoSize = true;
            this.L_subscribeStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_subscribeStatus.Location = new System.Drawing.Point(539, 32);
            this.L_subscribeStatus.Name = "L_subscribeStatus";
            this.L_subscribeStatus.Size = new System.Drawing.Size(42, 15);
            this.L_subscribeStatus.TabIndex = 1;
            this.L_subscribeStatus.Text = "Status";
            // 
            // tb_subscribeTopic
            // 
            this.tb_subscribeTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_subscribeTopic.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subscribeTopic.Location = new System.Drawing.Point(99, 24);
            this.tb_subscribeTopic.Name = "tb_subscribeTopic";
            this.tb_subscribeTopic.Size = new System.Drawing.Size(100, 32);
            this.tb_subscribeTopic.TabIndex = 0;
            // 
            // tb_publishTopic
            // 
            this.tb_publishTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_publishTopic.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_publishTopic.Location = new System.Drawing.Point(99, 73);
            this.tb_publishTopic.Name = "tb_publishTopic";
            this.tb_publishTopic.Size = new System.Drawing.Size(100, 32);
            this.tb_publishTopic.TabIndex = 1;
            // 
            // tb_publishContent
            // 
            this.tb_publishContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_publishContent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_publishContent.Location = new System.Drawing.Point(99, 113);
            this.tb_publishContent.Name = "tb_publishContent";
            this.tb_publishContent.Size = new System.Drawing.Size(100, 32);
            this.tb_publishContent.TabIndex = 2;
            // 
            // btn_subscribe
            // 
            this.btn_subscribe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_subscribe.AutoSize = true;
            this.btn_subscribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_subscribe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_subscribe.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subscribe.Location = new System.Drawing.Point(350, 23);
            this.btn_subscribe.Name = "btn_subscribe";
            this.btn_subscribe.Size = new System.Drawing.Size(113, 34);
            this.btn_subscribe.TabIndex = 3;
            this.btn_subscribe.Text = "Subscribe";
            this.btn_subscribe.UseVisualStyleBackColor = false;
            this.btn_subscribe.Click += new System.EventHandler(this.SubscribeClick);
            // 
            // btn_publish
            // 
            this.btn_publish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_publish.AutoSize = true;
            this.btn_publish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_publish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_publish.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_publish.Location = new System.Drawing.Point(362, 111);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(89, 36);
            this.btn_publish.TabIndex = 4;
            this.btn_publish.Text = "Publish";
            this.btn_publish.UseVisualStyleBackColor = false;
            this.btn_publish.Click += new System.EventHandler(this.PublishClick);
            // 
            // L_publishStatus
            // 
            this.L_publishStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_publishStatus.AutoSize = true;
            this.L_publishStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_publishStatus.Location = new System.Drawing.Point(539, 121);
            this.L_publishStatus.Name = "L_publishStatus";
            this.L_publishStatus.Size = new System.Drawing.Size(42, 15);
            this.L_publishStatus.TabIndex = 5;
            this.L_publishStatus.Text = "Status";
            // 
            // L_connect
            // 
            this.L_connect.AutoSize = true;
            this.L_connect.BackColor = System.Drawing.Color.Silver;
            this.L_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_connect.Location = new System.Drawing.Point(3, 3);
            this.L_connect.Margin = new System.Windows.Forms.Padding(3);
            this.L_connect.Name = "L_connect";
            this.L_connect.Size = new System.Drawing.Size(14, 14);
            this.L_connect.TabIndex = 6;
            // 
            // tb_content
            // 
            this.tlp.SetColumnSpan(this.tb_content, 2);
            this.tb_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_content.Location = new System.Drawing.Point(30, 160);
            this.tb_content.Margin = new System.Windows.Forms.Padding(10);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(496, 225);
            this.tb_content.TabIndex = 7;
            // 
            // MQTTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 415);
            this.Controls.Add(this.tlp);
            this.Name = "MQTTForm";
            this.Text = "MQTT";
            this.Load += new System.EventHandler(this.FormLoad);
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.TextBox tb_subscribeTopic;
        private System.Windows.Forms.TextBox tb_publishTopic;
        private System.Windows.Forms.TextBox tb_publishContent;
        private System.Windows.Forms.Button btn_subscribe;
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.Label L_subscribeStatus;
        private System.Windows.Forms.Label L_publishStatus;
        private System.Windows.Forms.Label L_connect;
        private System.Windows.Forms.TextBox tb_content;
    }
}

