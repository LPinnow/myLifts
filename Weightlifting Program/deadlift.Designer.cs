namespace WindowsFormsApplication1
{
    partial class deadlift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deadlift));
            this.dlWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dlWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // dlWebBrowser
            // 
            this.dlWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlWebBrowser.Enabled = true;
            this.dlWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.dlWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("dlWebBrowser.OcxState")));
            this.dlWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.dlWebBrowser.TabIndex = 0;
            // 
            // deadlift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.dlWebBrowser);
            this.Name = "deadlift";
            this.Text = "Deadlift";
            ((System.ComponentModel.ISupportInitialize)(this.dlWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser dlWebBrowser;

    }
}