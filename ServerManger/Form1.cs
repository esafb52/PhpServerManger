using System;
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

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/c php\m-php.exe -S 0.0.0.0:80";
            process.StartInfo = startInfo;
            process.Start();
           // start_server_2();
          

        }



        public void start_server_2()
        {
            //string goloba_app_path = "Global.Path\\mikhmon";
            //string a = goloba_app_path + @"\php\m-php.exe - S 0.0.0.0:";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = @"/c Global.Path\mikhmon\php\m-php.exe -S 0.0.0.0:80";
            //process.StartInfo = startInfo;
            //process.Start();
        
            Environment.CurrentDirectory = Environment.CurrentDirectory + "\\mikhmon";
            string cmd =  "\\php\\m-php.exe -S 0.0.0.0:80";       
            startInfo.Arguments = $"/c " + cmd;
            process.Start();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", "/c php\\stop-server.bat");
        }

        private void btn_opne_link_Click(object sender, EventArgs e)
        {
            String url = txt_ip.Text + ":" + txt_port.Text;
            Process.Start(url);
        }
    }
}
