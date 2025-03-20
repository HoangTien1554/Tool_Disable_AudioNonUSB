using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Disable_AudioNonUSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Disable_Audio()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "Disable_Audio.exe");

            // Ghi file EXE từ Resources ra thư mục tạm
            File.WriteAllBytes(tempPath, Properties.Resources.Disable_Audio);

            // Tạo ProcessStartInfo để chạy file
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = tempPath, // Chạy từ file đã trích xuất
                WindowStyle = ProcessWindowStyle.Hidden, // Ẩn cửa sổ
                CreateNoWindow = true, // Không tạo cửa sổ console
                UseShellExecute = false // Không sử dụng trình shell mặc định
            };

            Process process = new Process { StartInfo = startInfo };
            process.Start();
        }

        private void Enable_Audio()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "Enable_Audio.exe");

            // Ghi file EXE từ Resources ra thư mục tạm
            File.WriteAllBytes(tempPath, Properties.Resources.Enable_Audio);

            // Tạo ProcessStartInfo để chạy file
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = tempPath, // Chạy từ file đã trích xuất
                WindowStyle = ProcessWindowStyle.Hidden, // Ẩn cửa sổ
                CreateNoWindow = true, // Không tạo cửa sổ console
                UseShellExecute = false // Không sử dụng trình shell mặc định
            };

            Process process = new Process { StartInfo = startInfo };
            process.Start();
        }
        private void Max_Volume()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "Max_Volume.exe");

            // Ghi file EXE từ Resources ra thư mục tạm
            File.WriteAllBytes(tempPath, Properties.Resources.Max_Volume);

            // Tạo ProcessStartInfo để chạy file
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = tempPath, // Chạy từ file đã trích xuất
                WindowStyle = ProcessWindowStyle.Hidden, // Ẩn cửa sổ
                CreateNoWindow = true, // Không tạo cửa sổ console
                UseShellExecute = false // Không sử dụng trình shell mặc định
            };

            Process process = new Process { StartInfo = startInfo };
            process.Start();
        }

        private bool getSecureBoot_State()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = "-Command \"Confirm-SecureBootUEFI\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd().Trim();
                process.WaitForExit();

                return output == "True"; // Secure Boot được bật nếu trả về "True"
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false;
        }

        private bool getTPM_State()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = "-Command \"(Get-Tpm).TpmPresent\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd().Trim();
                process.WaitForExit();

                return output == "True"; // TPM được bật nếu trả về "True"
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return false; // Nếu có lỗi, giả định TPM không bật
        }

        private bool getHVCI_State()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = "-Command \"(Get-CimInstance -ClassName Win32_DeviceGuard -Namespace root\\Microsoft\\Windows\\DeviceGuard).AvailableSecurityProperties -contains 3\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd().Trim();
                process.WaitForExit();

                return output == "True"; // HVCI được bật nếu trả về "True"
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return false; // Nếu có lỗi, giả định HVCI không bật
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lab_SecureBoot.Text += getSecureBoot_State().ToString();
            lab_TPM.Text += getTPM_State().ToString();
            lab_HVCI.Text += getHVCI_State().ToString();
                
        }

        private void openHuongDan()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "Guide.txt");

            // Lưu file nếu chưa tồn tại
            if (!File.Exists(tempPath))
            {
                File.WriteAllText(tempPath, Properties.Resources.Guide);
            }

            // Mở file bằng chương trình mặc định
            Process.Start(new ProcessStartInfo
            {
                FileName = tempPath,
                UseShellExecute = true
            });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            if (chk_Audio.Checked == true)
            {
                Disable_Audio();
            }
            else
            {
                Enable_Audio();
            }

            if(chk_MaxVolume.Checked == true)
            {
                Max_Volume();
            }
        }

        private void btn_HDSecureboot_Click(object sender, EventArgs e)
        {
            openHuongDan();
        }
    }
}
