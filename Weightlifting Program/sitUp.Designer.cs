namespace WindowsFormsApplication1
{
    partial class sitUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sitUp));
            this.sitUpWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.sitUpWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // sitUpWebBrowser
            // 
            this.sitUpWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sitUpWebBrowser.Enabled = true;
            this.sitUpWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.sitUpWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sitUpWebBrowser.OcxState")));
            this.sitUpWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.sitUpWebBrowser.TabIndex = 0;
            // 
            // sitUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.sitUpWebBrowser);
            this.Name = "sitUp";
            this.Text = "Weighted Sit Up";
            ((System.ComponentModel.ISupportInitialize)(this.sitUpWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser sitUpWebBrowser;
    }
}