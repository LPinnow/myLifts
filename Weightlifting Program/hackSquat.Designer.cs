namespace WindowsFormsApplication1
{
    partial class hackSquat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hackSquat));
            this.hackSquatWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.hackSquatWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // hackSquatWebBrowser
            // 
            this.hackSquatWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hackSquatWebBrowser.Enabled = true;
            this.hackSquatWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.hackSquatWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("hackSquatWebBrowser.OcxState")));
            this.hackSquatWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.hackSquatWebBrowser.TabIndex = 0;
            // 
            // hackSquat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.hackSquatWebBrowser);
            this.Name = "hackSquat";
            this.Text = "hackSquat";
            ((System.ComponentModel.ISupportInitialize)(this.hackSquatWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser hackSquatWebBrowser;
    }
}