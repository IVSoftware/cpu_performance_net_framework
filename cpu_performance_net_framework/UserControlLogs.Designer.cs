namespace cpu_performance_net_framework
{
    partial class UserControlLogs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMemoryCommitted = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.timerUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.PerformanceCounterCPU = new System.Diagnostics.PerformanceCounter();
            this.PerformanceCounterCommittedMemory = new System.Diagnostics.PerformanceCounter();
            this.labelMemoryActive = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceCounterCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceCounterCommittedMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMemoryCommitted
            // 
            this.labelMemoryCommitted.AutoSize = true;
            this.labelMemoryCommitted.Location = new System.Drawing.Point(90, 64);
            this.labelMemoryCommitted.Name = "labelMemoryCommitted";
            this.labelMemoryCommitted.Size = new System.Drawing.Size(65, 20);
            this.labelMemoryCommitted.TabIndex = 1;
            this.labelMemoryCommitted.Text = "Memory";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(90, 28);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(42, 20);
            this.labelCPU.TabIndex = 2;
            this.labelCPU.Text = "CPU";
            // 
            // timerUpdateUI
            // 
            this.timerUpdateUI.Enabled = true;
            this.timerUpdateUI.Interval = 1000;
            this.timerUpdateUI.Tick += new System.EventHandler(this.timerUpdateUI_Tick);
            // 
            // PerformanceCounterCPU
            // 
            this.PerformanceCounterCPU.CategoryName = "Processor";
            this.PerformanceCounterCPU.CounterName = "% Processor Time";
            this.PerformanceCounterCPU.InstanceName = "_Total";
            // 
            // PerformanceCounterCommittedMemory
            // 
            this.PerformanceCounterCommittedMemory.CategoryName = "Memory";
            this.PerformanceCounterCommittedMemory.CounterName = "% Committed Bytes In Use";
            // 
            // labelMemoryActive
            // 
            this.labelMemoryActive.AutoSize = true;
            this.labelMemoryActive.Location = new System.Drawing.Point(90, 102);
            this.labelMemoryActive.Name = "labelMemoryActive";
            this.labelMemoryActive.Size = new System.Drawing.Size(65, 20);
            this.labelMemoryActive.TabIndex = 1;
            this.labelMemoryActive.Text = "Memory";
            // 
            // UserControlLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.labelMemoryActive);
            this.Controls.Add(this.labelMemoryCommitted);
            this.Controls.Add(this.labelCPU);
            this.Name = "UserControlLogs";
            this.Size = new System.Drawing.Size(194, 151);
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceCounterCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceCounterCommittedMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemoryCommitted;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Timer timerUpdateUI;
        private System.Diagnostics.PerformanceCounter PerformanceCounterCPU;
        private System.Diagnostics.PerformanceCounter PerformanceCounterCommittedMemory;
        private System.Windows.Forms.Label labelMemoryActive;
    }
}
