namespace WindowsFormsApplication1
{
    partial class legExtension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(legExtension));
            this.legExtenWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.legExtenWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // legExtenWebBrowser
            // 
            this.legExtenWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legExtenWebBrowser.Enabled = true;
            this.legExtenWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.legExtenWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("legExtenWebBrowser.OcxState")));
            this.legExtenWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.legExtenWebBrowser.TabIndex = 0;
            // 
            // legExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.legExtenWebBrowser);
            this.Name = "legExtension";
            this.Text = "Leg Extension";
            ((System.ComponentModel.ISupportInitialize)(this.legExtenWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser legExtenWebBrowser;
    }
}