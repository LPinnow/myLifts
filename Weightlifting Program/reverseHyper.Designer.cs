namespace WindowsFormsApplication1
{
    partial class reverseHyper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reverseHyper));
            this.hyperWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.hyperWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // hyperWebBrowser
            // 
            this.hyperWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hyperWebBrowser.Enabled = true;
            this.hyperWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.hyperWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("hyperWebBrowser.OcxState")));
            this.hyperWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.hyperWebBrowser.TabIndex = 0;
            // 
            // reverseHyper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.hyperWebBrowser);
            this.Name = "reverseHyper";
            this.Text = "Reverse Hyper Extension";
            ((System.ComponentModel.ISupportInitialize)(this.hyperWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser hyperWebBrowser;
    }
}