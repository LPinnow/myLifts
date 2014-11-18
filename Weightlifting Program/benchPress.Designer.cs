namespace WindowsFormsApplication1
{
    partial class benchPress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(benchPress));
            this.benchWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.benchWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // benchWebBrowser
            // 
            this.benchWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.benchWebBrowser.Enabled = true;
            this.benchWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.benchWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("benchWebBrowser.OcxState")));
            this.benchWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.benchWebBrowser.TabIndex = 0;
            // 
            // benchPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.benchWebBrowser);
            this.Name = "benchPress";
            this.Text = "Bench Press";
            ((System.ComponentModel.ISupportInitialize)(this.benchWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser benchWebBrowser;
       
    }
}