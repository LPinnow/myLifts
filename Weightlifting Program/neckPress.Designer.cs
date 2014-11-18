namespace WindowsFormsApplication1
{
    partial class neckPress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(neckPress));
            this.neckWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.neckWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // neckWebBrowser
            // 
            this.neckWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neckWebBrowser.Enabled = true;
            this.neckWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.neckWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("neckWebBrowser.OcxState")));
            this.neckWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.neckWebBrowser.TabIndex = 0;
            // 
            // neckPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.neckWebBrowser);
            this.Name = "neckPress";
            this.Text = "Behind-the-Neck Press";
            ((System.ComponentModel.ISupportInitialize)(this.neckWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser neckWebBrowser;
    }
}