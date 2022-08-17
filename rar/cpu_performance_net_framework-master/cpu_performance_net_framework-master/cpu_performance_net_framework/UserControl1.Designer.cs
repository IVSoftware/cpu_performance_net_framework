namespace cpu_performance_net_framework
{
    partial class UserControl1
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
            this.labelMemory = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.timerUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.PerformanceCounterCPU = new System.Diagnostics.PerformanceCounter();
            this.PerformanceCounterMemory = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceCounterCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceCounterMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(13, 57);
            this.labelMemory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(44, 13);
            this.labelMemory.TabIndex = 1;
            this.labelMemory.Text = "Memory";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(13, 20);
            this.labelCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(29, 13);
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
            // PerformanceCounterMemory
            // 
            this.PerformanceCounterMemory.CategoryName = "Memory";
            this.PerformanceCounterMemory.CounterName = "% Committed Bytes In Use";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.labelCPU);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(129, 98);
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceCounterCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceCounterMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Timer timerUpdateUI;
        private System.Diagnostics.PerformanceCounter PerformanceCounterCPU;
        private System.Diagnostics.PerformanceCounter PerformanceCounterMemory;
    }
}
