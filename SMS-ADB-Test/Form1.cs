using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_ADB_Test
{
    public partial class Form1 : Form
    {

        public int repeatinterval { get; set; }
        public int repeattimes { get; set; }
        public bool repeatbool { get; set; }
        public bool deviceconnected { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.ActiveControl = PhoneNumber;

            DetectADBDevice();
        }

        private void DetectADBDevice()
        {
            string[] mydeviceinfo = MyADBComm("devices -l").Split(' ');

            foreach (var property in mydeviceinfo)
            {
                if (property.Contains("model:"))
                {
                    label_mydevice.Text = "Device connected: " + property.Replace("model:", "");
                    label_mydevice.ForeColor = Color.Black;
                    groupbox_main.Enabled = true;
                }

            }
            EndADB();
        }

        private void EndADB()
        {
            MyADBComm("kill-server");
        }

        private static string MyADBComm(string myargs)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"adb.exe";
            process.StartInfo.Arguments = myargs;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;

            try
            {
                process.Start();
            }
            catch
            {
                Console.Write("\nadb.exe not found in program directory.");
                Console.ReadKey();
                Environment.Exit(000);
            }

            string output = process.StandardOutput.ReadToEnd();
            return output;

        }

        private async void SendSMS(string phonenumber, string messagetext, int repeatinterval, int repeattimes)
        {
            phonenumber = "\"" + phonenumber + "\"";
            messagetext = "\"" + messagetext + "\"";
            messagetext = messagetext.Replace(" ", @"\ ");

            for (int i = 0; i <= repeattimes; i++)
            {
                MyADBComm(@"shell service call isms 7 i32 0 s16 ""com.android.mms.service"" s16 " + phonenumber + @" s16 ""null"" s16 " + messagetext + @" s16 ""null"" s16 ""null""");
                await Task.Delay(repeatinterval);

            }

            SendButton.Text = "Send";
            EndADB();

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (groupbox_repeat.Enabled)
            {
                string timeunits = TimeUnitsBox.Text;
                if (timeunits.Contains("hour"))
                {
                    repeatinterval = int.Parse(RepeatIntervalBox.Text) * 3600000;
                }
                else if (timeunits.Contains("minute"))
                {
                    repeatinterval = int.Parse(RepeatIntervalBox.Text) * 60000;
                }
                else if (timeunits.Contains("second"))
                {
                    repeatinterval = int.Parse(RepeatIntervalBox.Text) * 1000;
                }
                repeattimes = int.Parse(NumTimesBox.Text);
            }
            else
            {
                repeatinterval = 0;
                repeattimes = 0;
            }

            if (SendButton.Text == "Send")
            {
                repeatbool = true;
                SendButton.Text = "Running...";
            } else if (SendButton.Text == "Running...")
            {
                repeatbool = false;
                SendButton.Text = "Send";
            }
            SendSMS(PhoneNumber.Text, MessageText.Text, repeatinterval, repeattimes);
        }

        private void MessageText_ExpandedView(object sender, EventArgs e)
        {
            if (MessageText.Dock == DockStyle.None)
            {
                MessageText.Dock = DockStyle.Fill;
                MessageText.BringToFront();
            } else if (MessageText.Dock == DockStyle.Fill)
            {
                MessageText.Dock = DockStyle.None;
            }
        }

        private void MessageText_MinimizedView(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageText.Dock = DockStyle.None;
            }

        }

        private void checkbox_repeat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_repeat.Checked)
            {
                groupbox_repeat.Enabled = true;
            } else if (!checkbox_repeat.Checked)
            {
                groupbox_repeat.Enabled = false;
            }
        }
    }
}
