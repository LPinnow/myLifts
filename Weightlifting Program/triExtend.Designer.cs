namespace WindowsFormsApplication1
{
    partial class triExtend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(triExtend));
            this.extendWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.extendWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // extendWebBrowser
            // 
            this.extendWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendWebBrowser.Enabled = true;
            this.extendWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.extendWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("extendWebBrowser.OcxState")));
            this.extendWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.extendWebBrowser.TabIndex = 0;
            // 
            // triExtend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.extendWebBrowser);
            this.Name = "triExtend";
            this.Text = "Cable Tricep Extension";
            ((System.ComponentModel.ISupportInitialize)(this.extendWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser extendWebBrowser;
    }
}