namespace WindowsFormsApplication1
{
    partial class lateralRaise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lateralRaise));
            this.lateralWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.lateralWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // lateralWebBrowser
            // 
            this.lateralWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lateralWebBrowser.Enabled = true;
            this.lateralWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.lateralWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("lateralWebBrowser.OcxState")));
            this.lateralWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.lateralWebBrowser.TabIndex = 0;
            // 
            // lateralRaise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.lateralWebBrowser);
            this.Name = "lateralRaise";
            this.Text = "Dumbbell Lateral Raise";
            ((System.ComponentModel.ISupportInitialize)(this.lateralWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser lateralWebBrowser;
    }
}