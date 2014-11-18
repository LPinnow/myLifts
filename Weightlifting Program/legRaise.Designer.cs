namespace WindowsFormsApplication1
{
    partial class legRaise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(legRaise));
            this.legRaiseWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.legRaiseWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // legRaiseWebBrowser
            // 
            this.legRaiseWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legRaiseWebBrowser.Enabled = true;
            this.legRaiseWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.legRaiseWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("legRaiseWebBrowser.OcxState")));
            this.legRaiseWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.legRaiseWebBrowser.TabIndex = 0;
            // 
            // legRaise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.legRaiseWebBrowser);
            this.Name = "legRaise";
            this.Text = "Hanging Leg Raise";
            ((System.ComponentModel.ISupportInitialize)(this.legRaiseWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser legRaiseWebBrowser;
    }
}