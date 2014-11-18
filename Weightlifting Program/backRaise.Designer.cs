namespace WindowsFormsApplication1
{
    partial class backRaise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backRaise));
            this.brWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.brWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // brWebBrowser
            // 
            this.brWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brWebBrowser.Enabled = true;
            this.brWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.brWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("brWebBrowser.OcxState")));
            this.brWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.brWebBrowser.TabIndex = 0;
            // 
            // backRaise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.brWebBrowser);
            this.Name = "backRaise";
            this.Text = "Back Raise";
            ((System.ComponentModel.ISupportInitialize)(this.brWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser brWebBrowser;
    }
}