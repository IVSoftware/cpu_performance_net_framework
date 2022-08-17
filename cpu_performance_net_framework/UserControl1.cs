using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

// https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.performancecounter?view=dotnet-plat-ext-6.0
namespace cpu_performance_net_framework
{
    public partial class UserControlLogs : UserControl
    {
        private static UserControlLogs _instance;
        public static UserControlLogs Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new UserControlLogs();
                return _instance;
            }
        }

        private UserControlLogs()
        {
            InitializeComponent();
        }

        private void timerUpdateUI_Tick(object sender, EventArgs e)
        {
            labelCPU.Text = $"CPU : {(int)PerformanceCounterCPU.NextValue()}%";
            labelMemory.Text = $"Memory : {(int)PerformanceCounterMemory.NextValue()}%";
            _colorToggle = !_colorToggle;
            if(_colorToggle)
            {
                BackColor = Color.LightCyan;
            }
            else
            {
                BackColor = Color.LightBlue;
            }
        }
        private bool _colorToggle = false;
    }
}
