namespace WindowsFormsApplication1
{
    partial class reverseFly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reverseFly));
            this.reverseFlyWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.reverseFlyWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // reverseFlyWebBrowser
            // 
            this.reverseFlyWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reverseFlyWebBrowser.Enabled = true;
            this.reverseFlyWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.reverseFlyWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reverseFlyWebBrowser.OcxState")));
            this.reverseFlyWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.reverseFlyWebBrowser.TabIndex = 0;
            // 
            // reverseFly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.reverseFlyWebBrowser);
            this.Name = "reverseFly";
            this.Text = "Dumbbell Reverse Fly";
            ((System.ComponentModel.ISupportInitialize)(this.reverseFlyWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser reverseFlyWebBrowser;
    }
}