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
    public partial class Form2 : Form
    {
        static int squat_rm;
        static int bench_rm;
        static int deadlift_rm;
        static int overhead_rm;

        public Form2()
        {
            InitializeComponent();
            this.results_grid.Rows.Add(3);
        }

        public void weights_entered(int squat, int bench, int deadlift, int overhead)
        {
            //Store user input values
            squat_rm = squat;
            bench_rm = bench;
            deadlift_rm = deadlift;
            overhead_rm = overhead;
        }

        public void populate_grid()
        {
            //Initialize first column with week numbers
            results_grid[0, 0].Value = 1;
            results_grid[0, 1].Value = 2;
            results_grid[0, 2].Value = 3;
            results_grid[0, 3].Value = 4;

            populate_wave_A();
            populate_wave_B();
            populate_wave_C();
            populate_wave_D();
        }

        private void populate_wave_A()
        {
            //Array to store 3 weights, one for each set
            int[] weight = new int[3];

            //Squat
            weight = calculate.wave_A(squat_rm);
            results_grid[1, 0].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n"+
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Bench
            weight = calculate.wave_A(bench_rm);
            results_grid[2, 0].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Deadlift
            weight = calculate.wave_A(deadlift_rm);
            results_grid[3, 0].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Overhead
            weight = calculate.wave_A(overhead_rm);
            results_grid[4, 0].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";
        }

        private void populate_wave_B()
        {
            //Array to store 3 weights, one for each set
            int[] weight = new int[3];

            //Squat
            weight = calculate.wave_B(squat_rm);
            results_grid[1, 1].Value = "Set 1: " + weight[0] + " lbs x 3 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 3 reps";

            //Bench
            weight = calculate.wave_B(bench_rm);
            results_grid[2, 1].Value = "Set 1: " + weight[0] + " lbs x 3 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 3 reps";

            //Deadlift
            weight = calculate.wave_B(deadlift_rm);
            results_grid[3, 1].Value = "Set 1: " + weight[0] + " lbs x 3 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 3 reps";

            //Overhead
            weight = calculate.wave_B(overhead_rm);
            results_grid[4, 1].Value = "Set 1: " + weight[0] + " lbs x 3 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 3 reps";
        }

        private void populate_wave_C()
        {
            //Array to store 3 weights, one for each set
            int[] weight = new int[3];

            //Squat
            weight = calculate.wave_C(squat_rm);
            results_grid[1, 2].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 1 reps";

            //Bench
            weight = calculate.wave_C(bench_rm);
            results_grid[2, 2].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 1 reps";

            //Deadlift
            weight = calculate.wave_C(deadlift_rm);
            results_grid[3, 2].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 1 reps";

            //Overhead
            weight = calculate.wave_C(overhead_rm);
            results_grid[4, 2].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 1 reps";

        }

        private void populate_wave_D()
        {
            //Array to store 3 weights, one for each set
            int[] weight = new int[3];

            //Squat
            weight = calculate.wave_D(squat_rm);
            results_grid[1, 3].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Bench
            weight = calculate.wave_D(bench_rm);
            results_grid[2, 3].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Deadlift
            weight = calculate.wave_D(deadlift_rm);
            results_grid[3, 3].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Overhead
            weight = calculate.wave_D(overhead_rm);
            results_grid[4, 3].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";
        }
    }
}
