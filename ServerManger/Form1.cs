﻿using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace ServerManger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txt_ip.Text = GetLocalIPAddress();

        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return "http://" + ip.ToString();
                }
            }
            throw new Exception("No network IPv4 address in the system!");
        }
        private void btn_start_server_Click(object sender, EventArgs e)
        {
            string start_server = @"/c php\m-php.exe -S 0.0.0.0:80";
            RunCmdCommnd(start_server);
        }

               
        public void RunCmdCommnd(string cmd)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = cmd;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            string stop_server = "/c php\\stop-server.bat";
            RunCmdCommnd(stop_server);
        }

        private void btn_opne_link_Click(object sender, EventArgs e)
        {
            String url = txt_ip.Text + ":" + txt_port.Text;
            Process.Start(url);
        }
    }
}
