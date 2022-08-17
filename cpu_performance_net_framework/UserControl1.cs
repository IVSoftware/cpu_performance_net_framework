using System;
using System.Diagnostics;
using System.Windows.Forms;

// https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.performancecounter?view=dotnet-plat-ext-6.0
namespace cpu_performance_net_framework
{
    public partial class UserControlLogs : UserControl
    {
        public UserControlLogs()
        {
            InitializeComponent();
        }
        private PerformanceCounter PerformanceCounterCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter PerformanceCounterMemory = new PerformanceCounter("Memory", "Available MBytes");
        private void timerUpdateUI_Tick(object sender, EventArgs e)
        {
            labelCPU.Text = $"CPU : {(int)PerformanceCounterCPU.NextValue()}%";
            labelMemory.Text = $"Memory : {(int)PerformanceCounterMemory.NextValue()}%";
        }
    }
}
