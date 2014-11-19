namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.calculate = new System.Windows.Forms.Button();
            this.overhead_input = new System.Windows.Forms.TextBox();
            this.deadlift_input = new System.Windows.Forms.TextBox();
            this.bench_input = new System.Windows.Forms.TextBox();
            this.squat_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.squatComboBox = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.benchComboBox = new System.Windows.Forms.ComboBox();
            this.deadliftComboBox = new System.Windows.Forms.ComboBox();
            this.overheadComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(256, 352);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // overhead_input
            // 
            this.overhead_input.Location = new System.Drawing.Point(270, 279);
            this.overhead_input.MaxLength = 4;
            this.overhead_input.Name = "overhead_input";
            this.overhead_input.Size = new System.Drawing.Size(61, 20);
            this.overhead_input.TabIndex = 3;
            this.overhead_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // deadlift_input
            // 
            this.deadlift_input.Location = new System.Drawing.Point(270, 228);
            this.deadlift_input.MaxLength = 4;
            this.deadlift_input.Name = "deadlift_input";
            this.deadlift_input.Size = new System.Drawing.Size(61, 20);
            this.deadlift_input.TabIndex = 2;
            this.deadlift_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // bench_input
            // 
            this.bench_input.Location = new System.Drawing.Point(270, 177);
            this.bench_input.MaxLength = 4;
            this.bench_input.Name = "bench_input";
            this.bench_input.Size = new System.Drawing.Size(61, 20);
            this.bench_input.TabIndex = 1;
            this.bench_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // squat_input
            // 
            this.squat_input.Location = new System.Drawing.Point(270, 124);
            this.squat_input.MaxLength = 4;
            this.squat_input.Name = "squat_input";
            this.squat_input.Size = new System.Drawing.Size(61, 20);
            this.squat_input.TabIndex = 0;
            this.squat_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1 RM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "1 RM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "1 RM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "1 RM:";
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(130, 352);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(75, 23);
            this.instructions.TabIndex = 9;
            this.instructions.Text = "Instructions";
            this.instructions.UseVisualStyleBackColor = true;
            this.instructions.Click += new System.EventHandler(this.instructClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.squat;
            this.pictureBox4.Location = new System.Drawing.Point(42, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.benchpress;
            this.pictureBox3.Location = new System.Drawing.Point(38, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.deadlift;
            this.pictureBox2.Location = new System.Drawing.Point(45, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.overhead;
            this.pictureBox1.Location = new System.Drawing.Point(44, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // squatComboBox
            // 
            this.squatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.squatComboBox.FormattingEnabled = true;
            this.squatComboBox.Items.AddRange(new object[] {
            "Squat",
            "Box Squat",
            "Front Squat"});
            this.squatComboBox.Location = new System.Drawing.Point(103, 124);
            this.squatComboBox.Name = "squatComboBox";
            this.squatComboBox.Size = new System.Drawing.Size(102, 21);
            this.squatComboBox.TabIndex = 14;
            // 
            // benchComboBox
            // 
            this.benchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.benchComboBox.FormattingEnabled = true;
            this.benchComboBox.Items.AddRange(new object[] {
            "Bench Press",
            "Floor Press",
            "Board Press",
            "Dumbbell Press"});
            this.benchComboBox.Location = new System.Drawing.Point(103, 177);
            this.benchComboBox.Name = "benchComboBox";
            this.benchComboBox.Size = new System.Drawing.Size(102, 21);
            this.benchComboBox.TabIndex = 15;
            // 
            // deadliftComboBox
            // 
            this.deadliftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deadliftComboBox.FormattingEnabled = true;
            this.deadliftComboBox.Items.AddRange(new object[] {
            "Deadlift",
            "Deficit Deadlift",
            "Rack Pull",
            "Sumo Deadlift"});
            this.deadliftComboBox.Location = new System.Drawing.Point(103, 228);
            this.deadliftComboBox.Name = "deadliftComboBox";
            this.deadliftComboBox.Size = new System.Drawing.Size(102, 21);
            this.deadliftComboBox.TabIndex = 16;
            // 
            // overheadComboBox
            // 
            this.overheadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.overheadComboBox.FormattingEnabled = true;
            this.overheadComboBox.Items.AddRange(new object[] {
            "Overhead Press",
            "Push Press",
            "Overhead DB Press",
            "Rack Press"});
            this.overheadComboBox.Location = new System.Drawing.Point(103, 279);
            this.overheadComboBox.Name = "overheadComboBox";
            this.overheadComboBox.Size = new System.Drawing.Size(102, 21);
            this.overheadComboBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 42);
            this.label5.TabIndex = 18;
            this.label5.Text = "myLifts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 412);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.overheadComboBox);
            this.Controls.Add(this.deadliftComboBox);
            this.Controls.Add(this.benchComboBox);
            this.Controls.Add(this.squatComboBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squat_input);
            this.Controls.Add(this.bench_input);
            this.Controls.Add(this.deadlift_input);
            this.Controls.Add(this.overhead_input);
            this.Controls.Add(this.calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Welcome to myLifts!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox overhead_input;
        private System.Windows.Forms.TextBox deadlift_input;
        private System.Windows.Forms.TextBox bench_input;
        private System.Windows.Forms.TextBox squat_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button instructions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox squatComboBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox benchComboBox;
        private System.Windows.Forms.ComboBox deadliftComboBox;
        private System.Windows.Forms.ComboBox overheadComboBox;
        private System.Windows.Forms.Label label5;
    }
}

