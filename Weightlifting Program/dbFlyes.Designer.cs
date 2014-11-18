namespace WindowsFormsApplication1
{
    partial class dbFlyes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbFlyes));
            this.dbWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dbWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // dbWebBrowser
            // 
            this.dbWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbWebBrowser.Enabled = true;
            this.dbWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.dbWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("dbWebBrowser.OcxState")));
            this.dbWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.dbWebBrowser.TabIndex = 0;
            // 
            // dbFlyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.dbWebBrowser);
            this.Name = "dbFlyes";
            this.Text = "Dumbbell Flyes";
            ((System.ComponentModel.ISupportInitialize)(this.dbWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser dbWebBrowser;
    }
}