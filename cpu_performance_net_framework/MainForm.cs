using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace cpu_performance_net_framework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            UserControlLogs.Stopwatch.Start();
            Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: MainForm CTor:");
            InitializeComponent();
        }

        private void buttonShowUC_Click(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: ShowUC Click:");
                _instance.Show();
            });
        }
    }
}
