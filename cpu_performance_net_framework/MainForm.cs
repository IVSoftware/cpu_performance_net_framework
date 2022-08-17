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
            _instance.Show();
        }
    }
}
