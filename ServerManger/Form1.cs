using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ServerManger
{
    public partial class Form1 : Form
    {
        public static bool IsServerRuning;
        public Form1()
        {
            InitializeComponent();
        }

        public string ReadPortFromFile()
        {
            string prot_file_path = @"php\port.ini";
            string resultString = "";
            if (File.Exists(prot_file_path))
            {
                string[] file_content = File.ReadAllLines(prot_file_path);
                resultString = Regex.Match(file_content[1], @"\d+").Value;
            }
            return resultString;
        }
        public static void WritePortToPortFile(string port)
        {
            string new_port = $"port={port}";
            string prot_file_path = @"php\port.ini";
            if (!File.Exists(prot_file_path))
                MessageBox.Show("فایل مورد نظر وحود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string[] arrLine = File.ReadAllLines(prot_file_path);
            arrLine[1] = port;
            File.WriteAllLines(prot_file_path, arrLine);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                txt_ip.Text = GetLocalIPAddress();
                txt_port.Text = ReadPortFromFile();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

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
            if (!IsServerRuning)
            {
                if (string.IsNullOrEmpty(txt_port.Text))
                {
                    MessageBox.Show("پورت مشخص نشده است  ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string start_server = $"/c php\\m-php.exe -S 0.0.0.0:{txt_port.Text.Trim()}";
                RunCmdCommnd(start_server);
                pictureBox_conect_state.Image = Properties.Resources.connectd;
                lbl_state.Text = "متصل ";
                IsServerRuning = true;
            }
            else
            {
                MessageBox.Show("سرور در حال اجرا است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        public void RunCmdCommnd(string cmd)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = cmd;
                process.StartInfo = startInfo;
                process.Start();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (IsServerRuning)
            {
                string stop_server = "/c php\\stop-server.bat";
                RunCmdCommnd(stop_server);
                pictureBox_conect_state.Image = Properties.Resources.disconnectd;
                lbl_state.Text = "خاموش";
                IsServerRuning = false;
            }
            else
            {
                MessageBox.Show("لطفا سرور را راه اندازی کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void btn_opne_link_Click(object sender, EventArgs e)
        {
            if (IsServerRuning)
            {
                String url = txt_ip.Text + ":" + txt_port.Text;
                Process.Start(url);
            }
            else
            {
                MessageBox.Show("سرور متوقف شده است ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_change_port_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_port.Text) || txt_port.Text.Length < 2)
            {
                MessageBox.Show(" مقدار پورت به صورت صحیح وارد نشده است  ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WritePortToPortFile(txt_port.Text);
            MessageBox.Show("با موفقیت انجام شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
