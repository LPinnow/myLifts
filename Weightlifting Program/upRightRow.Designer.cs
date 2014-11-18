namespace WindowsFormsApplication1
{
    partial class upRightRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(upRightRow));
            this.upRowWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.upRowWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // upRowWebBrowser
            // 
            this.upRowWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upRowWebBrowser.Enabled = true;
            this.upRowWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.upRowWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("upRowWebBrowser.OcxState")));
            this.upRowWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.upRowWebBrowser.TabIndex = 0;
            // 
            // upRightRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.upRowWebBrowser);
            this.Name = "upRightRow";
            this.Text = "Barbell Upright Row";
            ((System.ComponentModel.ISupportInitialize)(this.upRowWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser upRowWebBrowser;
    }
}