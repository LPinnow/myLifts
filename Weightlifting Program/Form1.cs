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
    public partial class Form1 : Form
    {
        static int squat;
        static int deadlift;
        static int bench;
        static int overhead;

        public Form1()
        {
            InitializeComponent();
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow user to enter digits otherwise display message prompt
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please Enter Only Digits (0-9)");
                e.Handled = true;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try {                                                               // try-catch block for format exceptions (blanks, non digits)
                //Store user input
                squat = Convert.ToInt16(squat_input.Text);
                deadlift = Convert.ToInt16(deadlift_input.Text);
                bench = Convert.ToInt16(bench_input.Text);
                overhead = Convert.ToInt16(overhead_input.Text);


                //Create and call the results form
                Form2 results = new Form2();
                results.weights_entered(squat, bench, deadlift, overhead);
                results.populate_grid();
                results.Show();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Please Enter Only Digits (0-9)");
            }
        }

        private void instructClick(object sender, EventArgs e)
        {
            instructForm instruct = new instructForm();
            instruct.Show();
        }

    }

}
