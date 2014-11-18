namespace WindowsFormsApplication1
{
    partial class chinUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chinUp));
            this.chinUpWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.chinUpWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // chinUpWebBrowser
            // 
            this.chinUpWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chinUpWebBrowser.Enabled = true;
            this.chinUpWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.chinUpWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("chinUpWebBrowser.OcxState")));
            this.chinUpWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.chinUpWebBrowser.TabIndex = 0;
            // 
            // chinUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.chinUpWebBrowser);
            this.Name = "chinUp";
            this.Text = "Chin Up";
            ((System.ComponentModel.ISupportInitialize)(this.chinUpWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser chinUpWebBrowser;
    }
}