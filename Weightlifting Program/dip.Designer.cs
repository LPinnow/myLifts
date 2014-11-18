namespace WindowsFormsApplication1
{
    partial class dip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dip));
            this.dipWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dipWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // dipWebBrowser
            // 
            this.dipWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dipWebBrowser.Enabled = true;
            this.dipWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.dipWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("dipWebBrowser.OcxState")));
            this.dipWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.dipWebBrowser.TabIndex = 0;
            // 
            // dip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.dipWebBrowser);
            this.Name = "dip";
            this.Text = "Weighted Dip";
            ((System.ComponentModel.ISupportInitialize)(this.dipWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser dipWebBrowser;
    }
}