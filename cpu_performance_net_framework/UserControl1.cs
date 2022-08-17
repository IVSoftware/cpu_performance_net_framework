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
        public static Stopwatch Stopwatch { get; } = new Stopwatch();
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
                var wdt = startWatchdog(TimeSpan.FromSeconds(2));
                try
                {
                    _ = Task.Run(() => getPerformance());
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
                    Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: Getting performance data");
                    UserControlLogs.Stopwatch.Restart();
                    cpu = (int)PerformanceCounterCPU.NextValue();
                    committed = (int)PerformanceCounterCommittedMemory.NextValue();
                    available = (int)PerformanceCounterAvailableMemory.NextValue();
                    cts.Cancel(); // Cancel the WDT
                    Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: Performance data received");
                    UserControlLogs.Stopwatch.Restart();
                }
                void updateUI()
                {
                    Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: UI Updating");
                    UserControlLogs.Stopwatch.Restart();
                    labelCPU.Text = $"{cpu}%";
                    labelMemoryCommitted.Text = $"{committed}%";
                    labelMemoryAvailable.Text = $"{available}%";

                    _colorToggle = !_colorToggle;
                    if(_colorToggle) BackColor = Color.LightCyan;
                    else BackColor = Color.LightBlue;
                    Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: UI Updated");
                    UserControlLogs.Stopwatch.Restart();
                }
                async Task startWatchdog(TimeSpan timeout)
                {
                    try
                    {
                        Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: Watchdog Started");
                        UserControlLogs.Stopwatch.Restart();
                        await Task.Delay(timeout, cts.Token);
                        Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: Watchdog Timed Out");
                        UserControlLogs.Stopwatch.Restart();
                        throw new TimeoutException();
                    }
                    catch (TaskCanceledException) 
                    {
                        Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: Watchdog Cancelled");
                        UserControlLogs.Stopwatch.Restart();
                    }
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
                    Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: Initializing Performance Counters");
                    UserControlLogs.Stopwatch.Restart();
                    PerformanceCounterCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    PerformanceCounterCommittedMemory = new PerformanceCounter("Memory", "% Committed Bytes In Use");
                    PerformanceCounterAvailableMemory = new PerformanceCounter("Memory", "Available MBytes");
                    timerUpdateUI.Enabled = true;
                    Debug.WriteLine($"{UserControlLogs.Stopwatch.Elapsed}: Initialization complete");
                    UserControlLogs.Stopwatch.Restart();
                }
            }
        }
        private bool _colorToggle = false;
    }
}
