namespace WindowsFormsApplication1
{
    partial class seatedPress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seatedPress));
            this.seatedPressWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.seatedPressWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // seatedPressWebBrowser
            // 
            this.seatedPressWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seatedPressWebBrowser.Enabled = true;
            this.seatedPressWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.seatedPressWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("seatedPressWebBrowser.OcxState")));
            this.seatedPressWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.seatedPressWebBrowser.TabIndex = 0;
            // 
            // seatedPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.seatedPressWebBrowser);
            this.Name = "seatedPress";
            this.Text = "Seated Dumbbell Press";
            ((System.ComponentModel.ISupportInitialize)(this.seatedPressWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser seatedPressWebBrowser;
    }
}