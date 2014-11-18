namespace WindowsFormsApplication1
{
    partial class barbellRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barbellRow));
            this.bbRowWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.bbRowWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // bbRowWebBrowser
            // 
            this.bbRowWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbRowWebBrowser.Enabled = true;
            this.bbRowWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.bbRowWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bbRowWebBrowser.OcxState")));
            this.bbRowWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.bbRowWebBrowser.TabIndex = 0;
            // 
            // barbellRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.bbRowWebBrowser);
            this.Name = "barbellRow";
            this.Text = "Bent Over Barbell Row";
            ((System.ComponentModel.ISupportInitialize)(this.bbRowWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser bbRowWebBrowser;
    }
}