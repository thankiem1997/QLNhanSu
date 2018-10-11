﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            View main = new View();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(main);
            main.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            View main = new View();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(main);
            main.Dock = DockStyle.Fill;
        }

        private void btnHeSoLuong_Click(object sender, EventArgs e)
        {
            UCHeSoLuong b = new UCHeSoLuong();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(b);
            b.Dock = DockStyle.Fill;

        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            UCHopDong b = new UCHopDong();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }
    }
}
