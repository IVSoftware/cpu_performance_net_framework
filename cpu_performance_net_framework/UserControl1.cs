using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.performancecounter?view=dotnet-plat-ext-6.0
namespace cpu_performance_net_framework
{
    public partial class UserControlLogs : UserControl
    {
        public UserControlLogs()
        {
            InitializeComponent();
            timerUpdateUI.Enabled = false;
        }
        private PerformanceCounter PerformanceCounterCPU = null;
        private PerformanceCounter PerformanceCounterCommittedMemory = null;
        private PerformanceCounter PerformanceCounterAvailableMemory = null;

        SemaphoreSlim _noReentrancy = new SemaphoreSlim(1, 1);

        // Handler is now async
        private async void timerUpdateUI_Tick(object sender, EventArgs e)
        {
            int cpu = 0, committed = 0, available = 0;
            
            // Skip if task is still busy getting the Performance Counter from last time.
            if (_noReentrancy.Wait(0))
            {
                var cts = new CancellationTokenSource();
                try
                {
                    var wdt = startWatchdog(TimeSpan.FromSeconds(2), cts.Token);
                    await Task.Run(() => getPerformance());
                    await wdt;
                    BeginInvoke((MethodInvoker)delegate { updateUI(); });
                }
                catch (TimeoutException ex)
                {
                    Debug.WriteLine($"{DateTime.Now} {ex.Message}");
                }
                finally
                {
                    _noReentrancy.Release();
                }

                void getPerformance()
                {
                    cpu = (int)PerformanceCounterCPU.NextValue();
                    committed = (int)PerformanceCounterCommittedMemory.NextValue();
                    available = (int)PerformanceCounterAvailableMemory.NextValue();
                    cts.Cancel();
                }
                void updateUI()
                {
                    labelCPU.Text = $"{cpu}%";
                    labelMemoryCommitted.Text = $"{committed}%";
                    labelMemoryAvailable.Text = $"{available}%";

                    _colorToggle = !_colorToggle;
                    if(_colorToggle) BackColor = Color.LightCyan;
                    else BackColor = Color.LightBlue;
                }
                async Task startWatchdog(TimeSpan timeout, CancellationToken token)
                {
                    try
                    {
                        await Task.Delay(timeout, token);
                        throw new TimeoutException();
                    }
                    catch (TaskCanceledException) { }
                }
            }
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if(Visible)
            {
                if(PerformanceCounterCPU == null)
                {
                    PerformanceCounterCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    PerformanceCounterCommittedMemory = new PerformanceCounter("Memory", "% Committed Bytes In Use");
                    PerformanceCounterAvailableMemory = new PerformanceCounter("Memory", "Available MBytes");
                    timerUpdateUI.Enabled = true;
                }
            }
        }
        private bool _colorToggle = false;
    }
}
