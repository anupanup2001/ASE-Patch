using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASE_Patch
{
    public partial class Form1 : Form
    {
        private Patcher[] m_patcherList = new Patcher[2];
        public Form1()
        {
            InitializeComponent();
            m_patcherList[0] = new Patcher("C:\\abcd.bin", new byte[] { 10, 11 }, new byte[] { 43, 55 }, 2);
            m_patcherList[0].InitializeFlags();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLog.Text = "Hello World";
            
        }
    }
}
