namespace cpu_performance_net_framework
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowUC = new System.Windows.Forms.Button();
            this.label1 = new cpu_performance_net_framework.UserControl1();
            this.SuspendLayout();
            // 
            // buttonShowUC
            // 
            this.buttonShowUC.Location = new System.Drawing.Point(33, 38);
            this.buttonShowUC.Name = "buttonShowUC";
            this.buttonShowUC.Size = new System.Drawing.Size(161, 44);
            this.buttonShowUC.TabIndex = 1;
            this.buttonShowUC.Text = "Show User Control";
            this.buttonShowUC.UseVisualStyleBackColor = true;
            this.buttonShowUC.Click += new System.EventHandler(this.buttonShowUC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 158);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowUC);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonShowUC;
        private cpu_performance_net_framework.UserControl1 label1;
    }
}

