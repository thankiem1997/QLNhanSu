using System;
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

        private void btnKhenTHuong_Click(object sender, EventArgs e)
        {
            KhenThuongTh th = new KhenThuongTh();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(th);
            th.Dock = DockStyle.Fill;

        }

        private void btnKyLuat_Click(object sender, EventArgs e)
        {
            KyLuat kl = new KyLuat();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(kl);
            kl.Dock = DockStyle.Fill;
        }
    }
}
