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
            if (!panel1.Controls.Contains(UserControlLogs.Instance))
            {
                panel1.Controls.Add(UserControlLogs.Instance);
                UserControlLogs.Instance.Dock = DockStyle.Fill;
                UserControlLogs.Instance.BringToFront();
            }
            else
            {
                UserControlLogs.Instance.BringToFront();
            }
        }
    }
}
