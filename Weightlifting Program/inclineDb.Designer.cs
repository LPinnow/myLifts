namespace WindowsFormsApplication1
{
    partial class inclineDb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inclineDb));
            this.inclineWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.inclineWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // inclineWebBrowser
            // 
            this.inclineWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inclineWebBrowser.Enabled = true;
            this.inclineWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.inclineWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("inclineWebBrowser.OcxState")));
            this.inclineWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.inclineWebBrowser.TabIndex = 0;
            // 
            // inclineDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.inclineWebBrowser);
            this.Name = "inclineDb";
            this.Text = "Incline Dumbbell Bench Press";
            ((System.ComponentModel.ISupportInitialize)(this.inclineWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser inclineWebBrowser;
    }
}