
namespace MQTT
{
    partial class InitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_init = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.AutoSize = true;
            this.btn_init.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_init.Location = new System.Drawing.Point(92, 84);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(110, 32);
            this.btn_init.TabIndex = 0;
            this.btn_init.Text = "New Client";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(92, 42);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(110, 26);
            this.tb_name.TabIndex = 1;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 141);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_init);
            this.Name = "InitForm";
            this.Text = "InitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.TextBox tb_name;
    }
}