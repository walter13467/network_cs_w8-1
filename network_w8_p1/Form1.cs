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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
