namespace WindowsFormsApplication1
{
    partial class barExtend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barExtend));
            this.barExtWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.barExtWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // barExtWebBrowser
            // 
            this.barExtWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barExtWebBrowser.Enabled = true;
            this.barExtWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.barExtWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("barExtWebBrowser.OcxState")));
            this.barExtWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.barExtWebBrowser.TabIndex = 0;
            // 
            // barExtend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.barExtWebBrowser);
            this.Name = "barExtend";
            this.Text = "Barbell Triceps Extension";
            ((System.ComponentModel.ISupportInitialize)(this.barExtWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser barExtWebBrowser;
    }
}