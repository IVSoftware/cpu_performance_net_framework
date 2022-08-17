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
            this.labelMemoryAvailable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.timerUpdateUI.Enabled = false;
            this.timerUpdateUI.Interval = 1000;
            this.timerUpdateUI.Tick += new System.EventHandler(this.timerUpdateUI_Tick);
            // 
            // labelMemoryActive
            // 
            this.labelMemoryAvailable.AutoSize = true;
            this.labelMemoryAvailable.Location = new System.Drawing.Point(90, 102);
            this.labelMemoryAvailable.Name = "labelMemoryActive";
            this.labelMemoryAvailable.Size = new System.Drawing.Size(65, 20);
            this.labelMemoryAvailable.TabIndex = 1;
            this.labelMemoryAvailable.Text = "Memory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Committed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available";
            // 
            // UserControlLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMemoryAvailable);
            this.Controls.Add(this.labelMemoryCommitted);
            this.Controls.Add(this.labelCPU);
            this.Name = "UserControlLogs";
            this.Size = new System.Drawing.Size(194, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemoryCommitted;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Timer timerUpdateUI;
        private System.Windows.Forms.Label labelMemoryAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}