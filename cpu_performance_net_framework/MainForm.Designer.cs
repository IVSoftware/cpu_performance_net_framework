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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonShowUC
            // 
            this.buttonShowUC.Location = new System.Drawing.Point(22, 25);
            this.buttonShowUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowUC.Name = "buttonShowUC";
            this.buttonShowUC.Size = new System.Drawing.Size(107, 29);
            this.buttonShowUC.TabIndex = 1;
            this.buttonShowUC.Text = "Show User Control";
            this.buttonShowUC.UseVisualStyleBackColor = true;
            this.buttonShowUC.Click += new System.EventHandler(this.buttonShowUC_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(134, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 145);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 196);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonShowUC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonShowUC;
        private System.Windows.Forms.Panel panel1;
    }
}

