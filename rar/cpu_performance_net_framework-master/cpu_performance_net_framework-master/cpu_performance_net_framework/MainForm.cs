using System;
using System.Windows.Forms;

namespace cpu_performance_net_framework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonShowUC_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl1.Instance))
            {
                panel1.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
            {
                UserControl1.Instance.BringToFront();
            }
        }
    }
}
