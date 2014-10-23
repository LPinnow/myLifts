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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.waveA_grid = new System.Windows.Forms.DataGridView();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waveB_grid = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waveC_grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waveD_grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.waveA_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveB_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveC_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveD_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // waveA_grid
            // 
            this.waveA_grid.AllowUserToDeleteRows = false;
            this.waveA_grid.AllowUserToResizeColumns = false;
            this.waveA_grid.AllowUserToResizeRows = false;
            this.waveA_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.waveA_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waveA_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.waveA_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waveA_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Week,
            this.Day1,
            this.Day2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waveA_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.waveA_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.waveA_grid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.waveA_grid.Location = new System.Drawing.Point(0, 12);
            this.waveA_grid.MinimumSize = new System.Drawing.Size(75, 50);
            this.waveA_grid.Name = "waveA_grid";
            this.waveA_grid.RowHeadersVisible = false;
            this.waveA_grid.RowHeadersWidth = 50;
            this.waveA_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.waveA_grid.Size = new System.Drawing.Size(448, 291);
            this.waveA_grid.TabIndex = 0;
            // 
            // Week
            // 
            this.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Week.HeaderText = "Week 1";
            this.Week.MinimumWidth = 50;
            this.Week.Name = "Week";
            this.Week.Width = 66;
            // 
            // Day1
            // 
            this.Day1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Day1.HeaderText = "Main Exercises";
            this.Day1.MinimumWidth = 150;
            this.Day1.Name = "Day1";
            this.Day1.Width = 150;
            // 
            // Day2
            // 
            this.Day2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Day2.HeaderText = "Accessory Exercises";
            this.Day2.MinimumWidth = 150;
            this.Day2.Name = "Day2";
            // 
            // waveB_grid
            // 
            this.waveB_grid.AllowUserToDeleteRows = false;
            this.waveB_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.waveB_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waveB_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.waveB_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waveB_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.main,
            this.accessory});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waveB_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.waveB_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.waveB_grid.Location = new System.Drawing.Point(454, 12);
            this.waveB_grid.Name = "waveB_grid";
            this.waveB_grid.RowHeadersVisible = false;
            this.waveB_grid.Size = new System.Drawing.Size(448, 291);
            this.waveB_grid.TabIndex = 1;
            // 
            // Day
            // 
            this.Day.HeaderText = "Week 2";
            this.Day.MinimumWidth = 50;
            this.Day.Name = "Day";
            this.Day.Width = 66;
            // 
            // main
            // 
            this.main.HeaderText = "Main Exercises";
            this.main.MinimumWidth = 150;
            this.main.Name = "main";
            this.main.Width = 150;
            // 
            // accessory
            // 
            this.accessory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accessory.HeaderText = "Accessory Exercises";
            this.accessory.MinimumWidth = 150;
            this.accessory.Name = "accessory";
            // 
            // waveC_grid
            // 
            this.waveC_grid.AllowUserToDeleteRows = false;
            this.waveC_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.waveC_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waveC_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.waveC_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waveC_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waveC_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.waveC_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.waveC_grid.Location = new System.Drawing.Point(0, 318);
            this.waveC_grid.Name = "waveC_grid";
            this.waveC_grid.RowHeadersVisible = false;
            this.waveC_grid.Size = new System.Drawing.Size(448, 291);
            this.waveC_grid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Week 3";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Main Exercises";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Accessory Exercises";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // waveD_grid
            // 
            this.waveD_grid.AllowUserToDeleteRows = false;
            this.waveD_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.waveD_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waveD_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.waveD_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waveD_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waveD_grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.waveD_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.waveD_grid.Location = new System.Drawing.Point(454, 318);
            this.waveD_grid.Name = "waveD_grid";
            this.waveD_grid.RowHeadersVisible = false;
            this.waveD_grid.Size = new System.Drawing.Size(448, 291);
            this.waveD_grid.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Week 4";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 67;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Main Exercises";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Accessory Exercises";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(906, 618);
            this.Controls.Add(this.waveD_grid);
            this.Controls.Add(this.waveC_grid);
            this.Controls.Add(this.waveB_grid);
            this.Controls.Add(this.waveA_grid);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculated Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.waveA_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveB_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveC_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveD_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView waveA_grid;
        private System.Windows.Forms.DataGridView waveB_grid;
        private System.Windows.Forms.DataGridView waveC_grid;
        private System.Windows.Forms.DataGridView waveD_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn main;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}