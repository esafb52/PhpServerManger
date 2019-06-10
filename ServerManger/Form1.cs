using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ServerManger
{
    public partial class FrmMain : Form
    {
        public static event NetworkAddressChangedEventHandler NetworkAddressChanged;
        public static bool IsServerRuning;
        public static string app_folder_path;
        public FrmMain()
        {
            InitializeComponent();
        }
        public string ReadPortFromFile()
        {
            string prot_file_path = @"php\port.ini";
            string resultString = "80";
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
            {
                MessageBox.Show("فایل مورد نظر وحود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string[] arrLine = File.ReadAllLines(prot_file_path);
            arrLine[1] = new_port;
            File.WriteAllLines(prot_file_path, arrLine);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
                txt_ip.Text = GetLocalIPAddress();
                txt_port.Text = ReadPortFromFile();
            }
            catch (Exception exception)
            {
                MessageBox.Show(" : خطایی رخ داد" + exception.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate { txt_ip.Text = GetLocalIPAddress(); });
        }

        public static string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return "http://" + ip.ToString();
                    }

                }
                return "";
            }
            catch (Exception exception)
            {

                MessageBox.Show(" : خطایی رخ داد" + exception.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
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
                if (!Directory.Exists("hormozmik"))
                {
                    MessageBox.Show("تنظیمات سرور یافت نشد ", "کد 98", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                if (!Directory.Exists("php"))
                {
                    MessageBox.Show("تنظیمات سرور یافت نشد ", "کد 97", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                app_folder_path = Environment.CurrentDirectory;
                string php_path = app_folder_path + "\\php\\";
                string final_php_path = FixSpaceCharInCmd(php_path);
                Environment.CurrentDirectory = Environment.CurrentDirectory + "\\hormozmik";
                string start_server = $"/c {final_php_path}m-php.exe -S 0.0.0.0:{txt_port.Text.Trim()}";
                RunCmdCommnd(start_server);
                pictureBox_conect_state.Image = Properties.Resources._012_connection_connect_512;
                btn_start_server.Text = "توقف سرور";
                lbl_state.Text = "متصل";
                IsServerRuning = true;

            }
            else
            {
                Environment.CurrentDirectory = app_folder_path;
                string stop_server = "/c php\\stop-server.bat";
                RunCmdCommnd(stop_server);
                pictureBox_conect_state.Image = Properties.Resources._013_disconnect_connection_512;
                btn_start_server.Text = "راه اندازی سرور";
                lbl_state.Text = "غیر متصل";
                IsServerRuning = false;
            }
        }
        public string FixSpaceCharInCmd(string cmd)
        {
            string res = "";
            if (cmd.ToLower().Contains(@"C:\Program Files (x86)\".ToLower()))
            {
                res = cmd.Replace(@"\Program Files (x86)\", @"\PROGRA~2\");
                return res;
            }
            if (cmd.ToLower().Contains(@"C:\Program Files\".ToLower()))
            {
                res = cmd.Replace(@"\Program Files\", @"\PROGRA~1\");
                return res;
            }
            else
                return cmd;
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
                MessageBox.Show(" : خطایی رخ داد" + exception.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btn_stop_server_Click(object sender, EventArgs e)
        {
            if (IsServerRuning)
            {
                string stop_server = "/c php\\stop-server.bat";
                RunCmdCommnd(stop_server);
                pictureBox_conect_state.Image = Properties.Resources._013_disconnect_connection_512;
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
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("لطفا ابتدا سرور را راه اندازی کنید ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_change_port_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_port.Text) || txt_port.Text.Length < 2)
            {
                MessageBox.Show(" مقدار پورت به صورت صحیح وارد نشده است  ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsServerRuning)
            {
                MessageBox.Show(" ابتدا سرور را متوقف نمایید  ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void sermangernotificon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            Activate();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsServerRuning)
            {
                string stop_server = "/c php\\stop-server.bat";
                RunCmdCommnd(stop_server);
            }
        }
    }
}
