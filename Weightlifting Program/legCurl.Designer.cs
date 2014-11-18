namespace WindowsFormsApplication1
{
    partial class legCurl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(legCurl));
            this.curlWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.curlWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // curlWebBrowser
            // 
            this.curlWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curlWebBrowser.Enabled = true;
            this.curlWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.curlWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("curlWebBrowser.OcxState")));
            this.curlWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.curlWebBrowser.TabIndex = 0;
            // 
            // legCurl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.curlWebBrowser);
            this.Name = "legCurl";
            this.Text = "Leg Curl";
            ((System.ComponentModel.ISupportInitialize)(this.curlWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser curlWebBrowser;
    }
}