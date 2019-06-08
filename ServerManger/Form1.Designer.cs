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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.pictureBox_conect_state = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_start_server = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_opne_link = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_change_port = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_conect_state)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.panel1.Size = new System.Drawing.Size(434, 220);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_state);
            this.groupBox3.Controls.Add(this.pictureBox_conect_state);
            this.groupBox3.Controls.Add(this.btn_close);
            this.groupBox3.Controls.Add(this.btn_start_server);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_opne_link);
            this.groupBox3.Controls.Add(this.txt_ip);
            this.groupBox3.Location = new System.Drawing.Point(14, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 133);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "راه اندازی سرور ";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(16, 33);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(45, 14);
            this.lbl_state.TabIndex = 9;
            this.lbl_state.Text = "خاموش";
            // 
            // pictureBox_conect_state
            // 
            this.pictureBox_conect_state.Image = global::ServerManger.Properties.Resources.disconnectd;
            this.pictureBox_conect_state.Location = new System.Drawing.Point(2, 58);
            this.pictureBox_conect_state.Name = "pictureBox_conect_state";
            this.pictureBox_conect_state.Size = new System.Drawing.Size(75, 72);
            this.pictureBox_conect_state.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_conect_state.TabIndex = 8;
            this.pictureBox_conect_state.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(108, 73);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 30);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "توقف سرور";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_start_server
            // 
            this.btn_start_server.Location = new System.Drawing.Point(304, 73);
            this.btn_start_server.Name = "btn_start_server";
            this.btn_start_server.Size = new System.Drawing.Size(92, 30);
            this.btn_start_server.TabIndex = 2;
            this.btn_start_server.Text = "راه اندازی سرور";
            this.btn_start_server.UseVisualStyleBackColor = true;
            this.btn_start_server.Click += new System.EventHandler(this.btn_start_server_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "وضعیت سرور : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "ip سیستم : ";
            // 
            // btn_opne_link
            // 
            this.btn_opne_link.Location = new System.Drawing.Point(206, 73);
            this.btn_opne_link.Name = "btn_opne_link";
            this.btn_opne_link.Size = new System.Drawing.Size(92, 30);
            this.btn_opne_link.TabIndex = 7;
            this.btn_opne_link.Text = "ورود به برنامه ";
            this.btn_opne_link.UseVisualStyleBackColor = true;
            this.btn_opne_link.Click += new System.EventHandler(this.btn_opne_link_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.Enabled = false;
            this.txt_ip.Location = new System.Drawing.Point(173, 30);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(145, 22);
            this.txt_ip.TabIndex = 6;
            this.txt_ip.Text = "192.168.1.1";
            this.txt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_change_port);
            this.groupBox1.Controls.Add(this.txt_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 68);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات پورت ";
            // 
            // btn_change_port
            // 
            this.btn_change_port.Location = new System.Drawing.Point(173, 21);
            this.btn_change_port.Name = "btn_change_port";
            this.btn_change_port.Size = new System.Drawing.Size(92, 30);
            this.btn_change_port.TabIndex = 8;
            this.btn_change_port.Text = "تغییر پورت";
            this.btn_change_port.UseVisualStyleBackColor = true;
            this.btn_change_port.Click += new System.EventHandler(this.btn_change_port_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(273, 26);
            this.txt_port.MaxLength = 4;
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(66, 22);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "80";
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_port_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "پورت : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(434, 220);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "هرمز میکروتیک";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_conect_state)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_start_server;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_opne_link;
        private System.Windows.Forms.Button btn_change_port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox_conect_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_state;
    }
}

