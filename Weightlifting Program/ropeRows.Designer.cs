namespace WindowsFormsApplication1
{
    partial class ropeRows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ropeRows));
            this.ropeRowWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.ropeRowWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // ropeRowWebBrowser
            // 
            this.ropeRowWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ropeRowWebBrowser.Enabled = true;
            this.ropeRowWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.ropeRowWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ropeRowWebBrowser.OcxState")));
            this.ropeRowWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.ropeRowWebBrowser.TabIndex = 0;
            // 
            // ropeRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.ropeRowWebBrowser);
            this.Name = "ropeRows";
            this.Text = "Rope Upright Row";
            ((System.ComponentModel.ISupportInitialize)(this.ropeRowWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser ropeRowWebBrowser;
    }
}