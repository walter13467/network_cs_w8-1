using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace network_w8_p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UdpClient U;
        Thread Th;

        ShapeContainer C;
        ShapeContainer D;
        Point stP;
        string p;

        private void Listen()
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Th.Abort();
                U.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Th = new Thread(Listen);
            Th.Start();
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C = new ShapeContainer();
            this.Controls.Add(C);
            D = new ShapeContainer();
            this.Controls.Add(D);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            stP = e.Location;
            p = stP.X.ToString() + "," + stP.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                LineShape L = new LineShape();
                L.StartPoint = stP;
                L.EndPoint = e.Location;
                L.Parent = C;
                stP = e.Location;

                p += "/" + stP.X.ToString() + "," + stP.Y.ToString(); //持續記錄座標
            }
        }
    }
}
