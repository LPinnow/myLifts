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
            //decides whether to chose Option A or B
            Random rnd = new Random();
            int option = rnd.Next(1);
            int notOption;
            if (option == 1)
                notOption = 0;
            else notOption = 1;

            populate_wave_A(option);
            populate_wave_B(notOption);
            populate_wave_C(option);
            populate_wave_D(notOption);
        }

        private void populate_wave_A(int option)
        {
            //Initialize first column with day numbers and exercise
            waveA_grid[0, 0].Value = "Day 1: Squat";
            waveA_grid[0, 1].Value = "Day 2: Bench Press";
            waveA_grid[0, 2].Value = "Day 3: Deadlift";
            waveA_grid[0, 3].Value = "Day 4: Overhead Press";

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

            switch (option)
            {
                //Option A
                case 0:
                    //accessory squat
                    waveA_grid[2, 0].Value = "Hack Squat: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //accessory bench
                    waveA_grid[2, 1].Value = "Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Cable Tricep Extension: 4 sets of 10-20 reps";
                    //accessory deadlift
                    waveA_grid[2, 2].Value = "Chin Up: 4 sets of 10-12 reps\n" + "Bent Over Dumbbell Row: 4 sets of 15 reps each arm\n" + "Back Raises: 4 sets of 15 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead
                    waveA_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Barbell Upright Row: 4 sets of 10 reps\n" + "Dumbbell Lateral Raises: 4 sets of 10-15 reps\n" + "Standing Barbell Curl: 4 sets of 10 reps\n";
                    break;
                //Option B
                case 1:
                    //accessory squat
                    waveA_grid[2, 0].Value = "Leg Press: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //acessory bench
                    waveA_grid[2, 1].Value = "Incline Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Lying Barbell Tricep Extensions: 4 sets of 10-20 reps";
                    //acesssory deadlift
                    waveA_grid[2, 2].Value = "Lat Pull Down: 4 sets of 10-12 reps\n" + "Bent Over Barbell Row: 4 sets of 10 reps\n" + " Reverse Hyperextensions: 4 sets of 12 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps\n";
                    //accessory overhead
                    waveA_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Rope Upright Rows: 4 sets of 10 reps\n" + "Bent Over Dumbbell Reverse Fly: 4 sets of 10-15 reps\n" + "Behind-the-Neck Overhead Press: 4 sets of 10 reps\n";
                    break;
                    

            }



        }

        private void populate_wave_B(int option)
        {
            waveB_grid[0, 0].Value = "Day 1: Squat";
            waveB_grid[0, 1].Value = "Day 2: Bench Press";
            waveB_grid[0, 2].Value = "Day 3: Deadlift";
            waveB_grid[0, 3].Value = "Day 4: Overhead Press";

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

            switch (option)
            {
                //Option A
                case 0:
                    //accessory squat
                    waveB_grid[2, 0].Value = "Hack Squat: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //accessory bench
                    waveB_grid[2, 1].Value = "Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Cable Tricep Extension: 4 sets of 10-20 reps";
                    //accessory deadlift
                    waveB_grid[2, 2].Value = "Chin Up: 4 sets of 10-12 reps\n" + "Bent Over Dumbbell Row: 4 sets of 15 reps each arm\n" + "Back Raises: 4 sets of 15 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead
                    waveB_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Barbell Upright Row: 4 sets of 10 reps\n" + "Dumbbell Lateral Raises: 4 sets of 10-15 reps\n" + "Standing Barbell Curl: 4 sets of 10 reps\n";
                    break;
                //Option B
                case 1:
                    //accessory squat
                    waveB_grid[2, 0].Value = "Leg Press: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //acessory bench
                    waveB_grid[2, 1].Value = "Incline Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Lying Barbell Tricep Extensions: 4 sets of 10-20 reps";
                    //acesssory deadlift
                    waveB_grid[2, 2].Value = "Lat Pull Down: 4 sets of 10-12 reps\n" + "Bent Over Barbell Row: 4 sets of 10 reps\n" + " Reverse Hyperextensions: 4 sets of 12 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps\n";
                    //accessory overhead
                    waveB_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Rope Upright Rows: 4 sets of 10 reps\n" + "Bent Over Dumbbell Reverse Fly: 4 sets of 10-15 reps\n" + "Behind-the-Neck Overhead Press: 4 sets of 10 reps\n";
                    break;


            }
        }

        private void populate_wave_C(int option)
        {
            waveC_grid[0, 0].Value = "Day 1: Squat";
            waveC_grid[0, 1].Value = "Day 2: Bench Press";
            waveC_grid[0, 2].Value = "Day 3: Deadlift";
            waveC_grid[0, 3].Value = "Day 4: Overhead Press";

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

            switch (option)
            {
                //Option A
                case 0:
                    //accessory squat
                    waveC_grid[2, 0].Value = "Hack Squat: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //accessory bench
                    waveC_grid[2, 1].Value = "Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Cable Tricep Extension: 4 sets of 10-20 reps";
                    //accessory deadlift
                    waveC_grid[2, 2].Value = "Chin Up: 4 sets of 10-12 reps\n" + "Bent Over Dumbbell Row: 4 sets of 15 reps each arm\n" + "Back Raises: 4 sets of 15 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead
                    waveC_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Barbell Upright Row: 4 sets of 10 reps\n" + "Dumbbell Lateral Raises: 4 sets of 10-15 reps\n" + "Standing Barbell Curl: 4 sets of 10 reps\n";
                    break;
                //Option B
                case 1:
                    //accessory squat
                    waveC_grid[2, 0].Value = "Leg Press: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //acessory bench
                    waveC_grid[2, 1].Value = "Incline Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Lying Barbell Tricep Extensions: 4 sets of 10-20 reps";
                    //acesssory deadlift
                    waveC_grid[2, 2].Value = "Lat Pull Down: 4 sets of 10-12 reps\n" + "Bent Over Barbell Row: 4 sets of 10 reps\n" + " Reverse Hyperextensions: 4 sets of 12 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps\n";
                    //accessory overhead
                    waveC_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Rope Upright Rows: 4 sets of 10 reps\n" + "Bent Over Dumbbell Reverse Fly: 4 sets of 10-15 reps\n" + "Behind-the-Neck Overhead Press: 4 sets of 10 reps\n";
                    break;


            }

        }

        private void populate_wave_D(int option)
        {
            waveD_grid[0, 0].Value = "Day 1: Squat";
            waveD_grid[0, 1].Value = "Day 2: Bench Press";
            waveD_grid[0, 2].Value = "Day 3: Deadlift";
            waveD_grid[0, 3].Value = "Day 4: Overhead Press";

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

            switch (option)
            {
                //Option A
                case 0:
                    //accessory squat
                    waveD_grid[2, 0].Value = "Hack Squat: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //accessory bench
                    waveD_grid[2, 1].Value = "Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Cable Tricep Extension: 4 sets of 10-20 reps";
                    //accessory deadlift
                    waveD_grid[2, 2].Value = "Chin Up: 4 sets of 10-12 reps\n" + "Bent Over Dumbbell Row: 4 sets of 15 reps each arm\n" + "Back Raises: 4 sets of 15 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead
                    waveD_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Barbell Upright Row: 4 sets of 10 reps\n" + "Dumbbell Lateral Raises: 4 sets of 10-15 reps\n" + "Standing Barbell Curl: 4 sets of 10 reps\n";
                    break;
                //Option B
                case 1:
                    //accessory squat
                    waveD_grid[2, 0].Value = "Leg Press: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //acessory bench
                    waveD_grid[2, 1].Value = "Incline Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Lying Barbell Tricep Extensions: 4 sets of 10-20 reps";
                    //acesssory deadlift
                    waveD_grid[2, 2].Value = "Lat Pull Down: 4 sets of 10-12 reps\n" + "Bent Over Barbell Row: 4 sets of 10 reps\n" + " Reverse Hyperextensions: 4 sets of 12 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps\n";
                    //accessory overhead
                    waveD_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Rope Upright Rows: 4 sets of 10 reps\n" + "Bent Over Dumbbell Reverse Fly: 4 sets of 10-15 reps\n" + "Behind-the-Neck Overhead Press: 4 sets of 10 reps\n";
                    break;


            }
        }

        
            
    }
}
