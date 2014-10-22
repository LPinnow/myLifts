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
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(240, 308);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // overhead_input
            // 
            this.overhead_input.Location = new System.Drawing.Point(230, 247);
            this.overhead_input.MaxLength = 4;
            this.overhead_input.Name = "overhead_input";
            this.overhead_input.Size = new System.Drawing.Size(100, 20);
            this.overhead_input.TabIndex = 3;
            this.overhead_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // deadlift_input
            // 
            this.deadlift_input.Location = new System.Drawing.Point(230, 203);
            this.deadlift_input.MaxLength = 4;
            this.deadlift_input.Name = "deadlift_input";
            this.deadlift_input.Size = new System.Drawing.Size(100, 20);
            this.deadlift_input.TabIndex = 2;
            this.deadlift_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // bench_input
            // 
            this.bench_input.Location = new System.Drawing.Point(230, 160);
            this.bench_input.MaxLength = 4;
            this.bench_input.Name = "bench_input";
            this.bench_input.Size = new System.Drawing.Size(100, 20);
            this.bench_input.TabIndex = 1;
            this.bench_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // squat_input
            // 
            this.squat_input.Location = new System.Drawing.Point(230, 116);
            this.squat_input.MaxLength = 4;
            this.squat_input.Name = "squat_input";
            this.squat_input.Size = new System.Drawing.Size(100, 20);
            this.squat_input.TabIndex = 0;
            this.squat_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Squat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bench Press";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deadlift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Overhead Press";
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(140, 307);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(75, 23);
            this.instructions.TabIndex = 9;
            this.instructions.Text = "Instructions";
            this.instructions.UseVisualStyleBackColor = true;
            this.instructions.Click += new System.EventHandler(this.instructClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 363);
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
            this.Name = "Form1";
            this.Text = "Welcome to myLifts!";
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
    }
}

