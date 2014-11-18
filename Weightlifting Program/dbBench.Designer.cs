namespace WindowsFormsApplication1
{
    partial class dbBench
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbBench));
            this.dbBenchWebBrowser = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dbBenchWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // dbBenchWebBrowser
            // 
            this.dbBenchWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbBenchWebBrowser.Enabled = true;
            this.dbBenchWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.dbBenchWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("dbBenchWebBrowser.OcxState")));
            this.dbBenchWebBrowser.Size = new System.Drawing.Size(661, 465);
            this.dbBenchWebBrowser.TabIndex = 0;
            // 
            // dbBench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.dbBenchWebBrowser);
            this.Name = "dbBench";
            this.Text = "Dumbbell Bench Press";
            ((System.ComponentModel.ISupportInitialize)(this.dbBenchWebBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser dbBenchWebBrowser;
    }
}