namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.results_grid = new System.Windows.Forms.DataGridView();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.results_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // results_grid
            // 
            this.results_grid.AllowUserToDeleteRows = false;
            this.results_grid.AllowUserToResizeColumns = false;
            this.results_grid.AllowUserToResizeRows = false;
            this.results_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.results_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.results_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Week,
            this.Day1,
            this.Day2,
            this.Day3,
            this.Day4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.results_grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.results_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.results_grid.Location = new System.Drawing.Point(0, 0);
            this.results_grid.MinimumSize = new System.Drawing.Size(50, 50);
            this.results_grid.Name = "results_grid";
            this.results_grid.RowHeadersVisible = false;
            this.results_grid.Size = new System.Drawing.Size(618, 484);
            this.results_grid.TabIndex = 0;
            // 
            // Week
            // 
            this.Week.HeaderText = "Week";
            this.Week.Name = "Week";
            this.Week.Width = 61;
            // 
            // Day1
            // 
            this.Day1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Day1.HeaderText = "Day 1 : Squat";
            this.Day1.Name = "Day1";
            this.Day1.Width = 89;
            // 
            // Day2
            // 
            this.Day2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Day2.HeaderText = "Day 2 : Bench Press";
            this.Day2.Name = "Day2";
            this.Day2.Width = 95;
            // 
            // Day3
            // 
            this.Day3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Day3.HeaderText = "Day 3 : Deadlift";
            this.Day3.Name = "Day3";
            this.Day3.Width = 96;
            // 
            // Day4
            // 
            this.Day4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Day4.HeaderText = "Day 4 : Overhead Press";
            this.Day4.Name = "Day4";
            this.Day4.Width = 109;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 484);
            this.Controls.Add(this.results_grid);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.results_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView results_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4;
    }
}