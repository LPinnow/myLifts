using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /**
     * GUI interface displayed when application is started
     * (Requirement 1.0.0)
     */
    public partial class Form1 : Form
    {
        static int squat;
        static int deadlift;
        static int bench;
        static int overhead;

        public Form1()
        {
            InitializeComponent();

            squatComboBox.SelectedIndex = 0;
            benchComboBox.SelectedIndex = 0;
            deadliftComboBox.SelectedIndex = 0;
            overheadComboBox.SelectedIndex = 0;
        }

        /**
         * Display error message if input is not a number
         * (Requirement 1.1.3)
         */
        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow user to enter digits otherwise display message prompt
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please Enter Only Digits (0-9)");
                e.Handled = true;
            }
        }

        /**
         * Calculate Button
         * (Requirement 1.1.0)
         */
        private void calculate_Click(object sender, EventArgs e)
        {
            // try-catch block for format exceptions (blanks, non digits)
            try {                                                               
                //Store user input
                squat = Convert.ToInt16(squat_input.Text);
                deadlift = Convert.ToInt16(deadlift_input.Text);
                bench = Convert.ToInt16(bench_input.Text);
                overhead = Convert.ToInt16(overhead_input.Text);

                String squatSub = this.squatComboBox.Items[this.squatComboBox.SelectedIndex].ToString();
                String benchSub = this.benchComboBox.Items[this.benchComboBox.SelectedIndex].ToString();
                String deadliftSub = this.deadliftComboBox.Items[this.deadliftComboBox.SelectedIndex].ToString();
                String overheadSub = this.overheadComboBox.Items[this.overheadComboBox.SelectedIndex].ToString();

                /**
                 * Create and call the results form
                 * (Requirement 1.1.1)
                 */
                Form2 results = new Form2();
                results.weights_entered(squat, bench, deadlift, overhead);
                results.substitution_exercises(squatSub, benchSub, deadliftSub, overheadSub);
                results.populate_grid();
                results.Show();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Please Enter Only Digits (0-9)");
            }
        }

        /**
         * Instructions Button
         * (Requirement 1.3.0)
         */
        private void instructClick(object sender, EventArgs e)
        {
            // Seperate instruction form (Requirement 1.3.1)
            instructForm instruct = new instructForm();
            instruct.Show();
        }

        


    }

}
