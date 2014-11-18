namespace WindowsFormsApplication1
{
    partial class backSquat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backSquat));
            this.squatWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.squatWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // squatWebBrowser
            // 
            this.squatWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squatWebBrowser.Enabled = true;
            this.squatWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.squatWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("squatWebBrowser.OcxState")));
            this.squatWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.squatWebBrowser.TabIndex = 0;
            // 
            // backSquat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.squatWebBrowser);
            this.Name = "backSquat";
            this.Text = "Back Squat";
            ((System.ComponentModel.ISupportInitialize)(this.squatWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser squatWebBrowser;

    }
}