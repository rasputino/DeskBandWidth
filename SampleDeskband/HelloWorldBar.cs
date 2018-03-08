using System;
using System.ComponentModel;
using System.Windows.Forms;

using BandObjectLib;
using System.Runtime.InteropServices;
using WindowsInput.Native;
using WindowsInput;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;

namespace SampleBandsDB
{
    [Guid("AE07101B-46D4-4a98-AF68-0333EA26E113")]
    [BandObject("Hello World Bar", BandObjectStyle.Horizontal | BandObjectStyle.ExplorerToolbar | BandObjectStyle.TaskbarToolBar, HelpText = "Shows bar that says hello.")]
    public class HelloWorldBar : BandObject
    {
        private Label label1;
        private System.ComponentModel.Container components = null;

        public HelloWorldBar()
        {
            InitializeComponent();

            if (!NetworkInterface.GetIsNetworkAvailable())
                throw new Exception("FALLO!");

            while(true)
            {
                NetStats();
                Thread.Sleep(1000);  
                               
            }

        }

        private void NetStats()
        {
            NetworkInterface[] interfaces
                = NetworkInterface.GetAllNetworkInterfaces();

            long sent = 0, received = 0;
            foreach (NetworkInterface ni in interfaces)
            {
                Debug.WriteLine("    Bytes Sent: {0}",
                    ni.GetIPv4Statistics().BytesSent);
                sent += ni.GetIPv4Statistics().BytesSent;
                Debug.WriteLine("    Bytes Received: {0}",
                    ni.GetIPv4Statistics().BytesReceived);
                received += ni.GetIPv4Statistics().BytesReceived;
            }

            label1.Text = sent.ToString();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // HelloWorldBar
            // 
            this.Controls.Add(this.label1);
            this.MinSize = new System.Drawing.Size(92, 30);
            this.Name = "HelloWorldBar";
            this.Size = new System.Drawing.Size(92, 30);
            this.Title = "Hello Bar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e)
        {
            InputSimulator s = new InputSimulator();
            //s.Keyboard.ModifiedKeyStroke(new [] { VirtualKeyCode.LWIN, VirtualKeyCode.LCONTROL }, VirtualKeyCode.LEFT);
            s.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PREV_TRACK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputSimulator s = new InputSimulator();
            //s.Keyboard.ModifiedKeyStroke(new[] { VirtualKeyCode.LWIN, VirtualKeyCode.LCONTROL }, VirtualKeyCode.RIGHT);
            s.Keyboard.KeyPress(VirtualKeyCode.MEDIA_NEXT_TRACK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputSimulator s = new InputSimulator();
            //s.Keyboard.ModifiedKeyStroke(new[] { VirtualKeyCode.LWIN, VirtualKeyCode.LCONTROL }, VirtualKeyCode.RIGHT);
            s.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PLAY_PAUSE);
        }

    }
}
