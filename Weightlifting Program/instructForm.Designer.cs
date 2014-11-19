namespace WindowsFormsApplication1
{
    partial class instructForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.instructBack = new System.Windows.Forms.Button();
            this.squatDayBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.benchDayBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dlDayBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.overHeadBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 208);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to myLifts!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructBack
            // 
            this.instructBack.Location = new System.Drawing.Point(399, 12);
            this.instructBack.Name = "instructBack";
            this.instructBack.Size = new System.Drawing.Size(60, 23);
            this.instructBack.TabIndex = 2;
            this.instructBack.Text = "BACK";
            this.instructBack.UseVisualStyleBackColor = true;
            this.instructBack.Click += new System.EventHandler(this.backClick);
            // 
            // squatDayBox
            // 
            this.squatDayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.squatDayBox.FormattingEnabled = true;
            this.squatDayBox.Items.AddRange(new object[] {
            "Back Squat",
            "Hack Squat",
            "Leg Extension",
            "Leg Curl",
            "Weighted Sit Up"});
            this.squatDayBox.Location = new System.Drawing.Point(27, 345);
            this.squatDayBox.Name = "squatDayBox";
            this.squatDayBox.Size = new System.Drawing.Size(121, 21);
            this.squatDayBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.viewSquatVideo);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tutorial Videos";
            // 
            // benchDayBox
            // 
            this.benchDayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.benchDayBox.FormattingEnabled = true;
            this.benchDayBox.Items.AddRange(new object[] {
            "Bench Press",
            "Barbell Tricep Extension",
            "Cable Tricep Extension",
            "Dumbbell Flyes",
            "Dumbbell Press",
            "Incline Dumbbell Bench Press",
            "Weighted Dip"});
            this.benchDayBox.Location = new System.Drawing.Point(272, 345);
            this.benchDayBox.Name = "benchDayBox";
            this.benchDayBox.Size = new System.Drawing.Size(121, 21);
            this.benchDayBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.viewBenchVideo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(56, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Squat Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(294, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bench Day";
            // 
            // dlDayBox
            // 
            this.dlDayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dlDayBox.FormattingEnabled = true;
            this.dlDayBox.Items.AddRange(new object[] {
            "Deadlift",
            "Back Raise",
            "Bent Over Barbell Row",
            "Bent Over Dumbbell Row",
            "Chin Up",
            "Hanging Leg raise",
            "Lat Pull Down",
            "Reverse Hyperextension"});
            this.dlDayBox.Location = new System.Drawing.Point(27, 402);
            this.dlDayBox.Name = "dlDayBox";
            this.dlDayBox.Size = new System.Drawing.Size(121, 21);
            this.dlDayBox.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 21);
            this.button3.TabIndex = 11;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.viewDLVideo);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(56, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Deadlift Day";
            // 
            // overHeadBox
            // 
            this.overHeadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.overHeadBox.FormattingEnabled = true;
            this.overHeadBox.Items.AddRange(new object[] {
            "Overhead Press",
            "Barbell Upright Row",
            "Behind-the-Neck Press",
            "Bent Over DB Reverse Fly",
            "Dumbbell Lateral Raises",
            "Rope Upright Rows",
            "Seated Dumbbell Press"});
            this.overHeadBox.Location = new System.Drawing.Point(272, 402);
            this.overHeadBox.Name = "overHeadBox";
            this.overHeadBox.Size = new System.Drawing.Size(121, 21);
            this.overHeadBox.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(399, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.viewOhVideo);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(294, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "OH Press Day";
            // 
            // instructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 447);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.overHeadBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dlDayBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.benchDayBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.squatDayBox);
            this.Controls.Add(this.instructBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "instructForm";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button instructBack;
        private System.Windows.Forms.ComboBox squatDayBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox benchDayBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dlDayBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox overHeadBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
    }
}