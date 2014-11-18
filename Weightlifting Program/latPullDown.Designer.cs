namespace WindowsFormsApplication1
{
    partial class latPullDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(latPullDown));
            this.latWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.latWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // latWebBrowser
            // 
            this.latWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latWebBrowser.Enabled = true;
            this.latWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.latWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("latWebBrowser.OcxState")));
            this.latWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.latWebBrowser.TabIndex = 0;
            // 
            // latPullDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.latWebBrowser);
            this.Name = "latPullDown";
            this.Text = "Lat Pull Down";
            ((System.ComponentModel.ISupportInitialize)(this.latWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser latWebBrowser;
    }
}