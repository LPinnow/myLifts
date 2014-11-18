namespace WindowsFormsApplication1
{
    partial class overheadPress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overheadPress));
            this.overheadWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.overheadWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // overheadWebBrowser
            // 
            this.overheadWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overheadWebBrowser.Enabled = true;
            this.overheadWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.overheadWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("overheadWebBrowser.OcxState")));
            this.overheadWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.overheadWebBrowser.TabIndex = 0;
            // 
            // overheadPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.overheadWebBrowser);
            this.Name = "overheadPress";
            this.Text = "Overhead Press";
            ((System.ComponentModel.ISupportInitialize)(this.overheadWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser overheadWebBrowser;

    }
}