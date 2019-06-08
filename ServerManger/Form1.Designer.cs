namespace ServerManger
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_start_server = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_opne_link = new System.Windows.Forms.Button();
            this.btn_change_port = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(609, 272);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_change_port);
            this.groupBox2.Controls.Add(this.btn_opne_link);
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_ip);
            this.groupBox2.Controls.Add(this.btn_start_server);
            this.groupBox2.Controls.Add(this.txt_port);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 252);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "راه اندازی سرور ";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(255, 136);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 33);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "توقف سرور";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ip سیستم : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "پورت : ";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(107, 31);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(152, 20);
            this.txt_ip.TabIndex = 6;
            this.txt_ip.Text = "192.168.1.1";
            // 
            // btn_start_server
            // 
            this.btn_start_server.Location = new System.Drawing.Point(353, 136);
            this.btn_start_server.Name = "btn_start_server";
            this.btn_start_server.Size = new System.Drawing.Size(92, 33);
            this.btn_start_server.TabIndex = 2;
            this.btn_start_server.Text = "راه اندازی سرور";
            this.btn_start_server.UseVisualStyleBackColor = true;
            this.btn_start_server.Click += new System.EventHandler(this.btn_start_server_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(107, 64);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(152, 20);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "80";
            // 
            // btn_opne_link
            // 
            this.btn_opne_link.Location = new System.Drawing.Point(154, 137);
            this.btn_opne_link.Name = "btn_opne_link";
            this.btn_opne_link.Size = new System.Drawing.Size(85, 32);
            this.btn_opne_link.TabIndex = 7;
            this.btn_opne_link.Text = "بازکردن برنامه";
            this.btn_opne_link.UseVisualStyleBackColor = true;
            this.btn_opne_link.Click += new System.EventHandler(this.btn_opne_link_Click);
            // 
            // btn_change_port
            // 
            this.btn_change_port.Location = new System.Drawing.Point(15, 59);
            this.btn_change_port.Name = "btn_change_port";
            this.btn_change_port.Size = new System.Drawing.Size(77, 29);
            this.btn_change_port.TabIndex = 8;
            this.btn_change_port.Text = "تغییر پورت";
            this.btn_change_port.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 272);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_start_server;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_opne_link;
        private System.Windows.Forms.Button btn_change_port;
    }
}

