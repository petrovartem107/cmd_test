using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmd_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunCMD("time");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            RunCMD(textBox2.Text);
        }
        private void RunCMD(string input)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "cmd",
                Arguments = $"/c chcp 1251 & {input}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            };
            
            //ProcessStartInfo info2 = new ProcessStartInfo()
            //{
            //    FileName = "cmd",
            //    //Arguments = $"/c chcp 65001 & {input}",
            //    Arguments = $"/c {input}",
            //    UseShellExecute = false,
            //    CreateNoWindow = true,
            //    RedirectStandardOutput = true
            //};
            Process process = Process.Start(info);
            string x = process.StandardOutput.ReadToEnd();
            //process = Process.Start(info2);
            textBox1.Text = x.Replace("’ҐЄгй п Є®¤®ў п бва ­Ёж : 1251", "");
        }
    }
}
