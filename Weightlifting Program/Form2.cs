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
            this.waveA_grid.Rows.Add(3);
            this.waveB_grid.Rows.Add(3);
            this.waveC_grid.Rows.Add(3);
            this.waveD_grid.Rows.Add(3);
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
            populate_wave_A();
            populate_wave_B();
            populate_wave_C();
            populate_wave_D();
        }

        private void populate_wave_A()
        {
            //Initialize first column with day numbers
            waveA_grid[0, 0].Value = "Day 1";
            waveA_grid[0, 1].Value = "Day 2";
            waveA_grid[0, 2].Value = "Day 3";
            waveA_grid[0, 3].Value = "Day 4";

            //Array to store 3 weights, one for each set
            int[] weight = new int[3];

            //Squat
            weight = calculate.wave_A(squat_rm);
            waveA_grid[1, 0].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps+";

            //Bench
            weight = calculate.wave_A(bench_rm);
            waveA_grid[1, 1].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps+";

            //Deadlift
            weight = calculate.wave_A(deadlift_rm);
            waveA_grid[1, 2].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps+";

            //Overhead
            weight = calculate.wave_A(overhead_rm);
            waveA_grid[1, 3].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps+";
        }

        private void populate_wave_B()
        {
            waveB_grid[0, 0].Value = "Day 1";
            waveB_grid[0, 1].Value = "Day 2";
            waveB_grid[0, 2].Value = "Day 3";
            waveB_grid[0, 3].Value = "Day 4";

            //Array to store 3 weights, one for each set
            int[] weight = new int[3];

            //Squat
            weight = calculate.wave_B(squat_rm);
            waveB_grid[1, 0].Value = "Set 1: " + weight[0] + " lbs x 3 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 3 reps+";
            //Bench
            weight = calculate.wave_B(bench_rm);
            waveB_grid[1, 1].Value = "Set 1: " + weight[0] + " lbs x 3 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 3 reps+";

            //Deadlift
            weight = calculate.wave_B(deadlift_rm);
            waveB_grid[1, 2].Value = "Set 1: " + weight[0] + " lbs x 3 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 3 reps+";

            //Overhead
            weight = calculate.wave_B(overhead_rm);
            waveB_grid[1, 3].Value = "Set 1: " + weight[0] + " lbs x 3 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 3 reps+";
        }

        private void populate_wave_C()
        {
            waveC_grid[0, 0].Value = "Day 1";
            waveC_grid[0, 1].Value = "Day 2";
            waveC_grid[0, 2].Value = "Day 3";
            waveC_grid[0, 3].Value = "Day 4";

            //Array to store 3 weights, one for each set
            int[] weight = new int[3];

            //Squat
            weight = calculate.wave_C(squat_rm);
            waveC_grid[1, 0].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 1 reps+";

            //Bench
            weight = calculate.wave_C(bench_rm);
            waveC_grid[1, 1].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 1 reps+";

            //Deadlift
            weight = calculate.wave_C(deadlift_rm);
            waveC_grid[1, 2].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 1 reps+";

            //Overhead
            weight = calculate.wave_C(overhead_rm);
            waveC_grid[1, 3].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 3 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 1 reps+";

        }

        private void populate_wave_D()
        {
            waveD_grid[0, 0].Value = "Day 1";
            waveD_grid[0, 1].Value = "Day 2";
            waveD_grid[0, 2].Value = "Day 3";
            waveD_grid[0, 3].Value = "Day 4";

            //Array to store 3 weights, one for each set
            int[] weight = new int[3];

            //Squat
            weight = calculate.wave_D(squat_rm);
            waveD_grid[1, 0].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Bench
            weight = calculate.wave_D(bench_rm);
            waveD_grid[1, 1].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Deadlift
            weight = calculate.wave_D(deadlift_rm);
            waveD_grid[1, 2].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";

            //Overhead
            weight = calculate.wave_D(overhead_rm);
            waveD_grid[1, 3].Value = "Set 1: " + weight[0] + " lbs x 5 reps\n" +
                                       "Set 2: " + weight[1] + " lbs x 5 reps\n" +
                                       "Set 3: " + weight[2] + " lbs x 5 reps";
        }
            
    }
}
