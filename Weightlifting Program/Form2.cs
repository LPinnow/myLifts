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
     * Output is displayed in a separate window when Calculate button is pressed
     * (Requirement 3.0.0)
     */
    public partial class Form2 : Form
    {
        static int squat_rm;
        static int bench_rm;
        static int deadlift_rm;
        static int overhead_rm;

        String squatExercise = "Squat";
        String benchExercise = "Bench Press";
        String deadliftExercise = "Deadlift";
        String overheadExercise = "Overhead Press";

        public Form2()
        {
            /**
             * Output is displayed in a table
             * (Requirement 3.1.0)
             */
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

        /**
         * Substituion exercise names output based on user selection
         * (Requirement 1.2.1)
         */
        public void substitution_exercises(String squatSubstitution, String benchSubstitution, String deadliftSubstitution, String overheadSubstitution)
        {
            //Store user selected exercises
            squatExercise = squatSubstitution;
            benchExercise = benchSubstitution;
            deadliftExercise = deadliftSubstitution;
            overheadExercise = overheadSubstitution;
        }

        public void populate_grid()
        {
            /**
             * Accessory exercises A or B are generated
             * (Requirement 2.2.0)
             */
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
            waveA_grid[0, 0].Value = "Day 1: " + squatExercise;
            waveA_grid[0, 1].Value = "Day 2: " + benchExercise;
            waveA_grid[0, 2].Value = "Day 3: " + deadliftExercise;
            waveA_grid[0, 3].Value = "Day 4: " + overheadExercise;

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
                    //accessory squat (Requirement 2.2.1)
                    waveA_grid[2, 0].Value = "Hack Squat: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //accessory bench (Requirement 2.2.2)
                    waveA_grid[2, 1].Value = "Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Cable Tricep Extension: 4 sets of 10-20 reps";
                    //accessory deadlift (Requirement 2.2.3)
                    waveA_grid[2, 2].Value = "Chin Up: 4 sets of 10-12 reps\n" + "Bent Over Dumbbell Row: 4 sets of 15 reps each arm\n" + "Back Raises: 4 sets of 15 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead (Requirement 2.2.4)
                    waveA_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Barbell Upright Row: 4 sets of 10 reps\n" + "Dumbbell Lateral Raises: 4 sets of 10-15 reps\n" + "Standing Barbell Curl: 4 sets of 10 reps\n";
                    break;
                //Option B
                case 1:
                    //accessory squat (Requirement 2.2.1)
                    waveA_grid[2, 0].Value = "Leg Press: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //acessory bench (Requirement 2.2.2)
                    waveA_grid[2, 1].Value = "Incline Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Lying Barbell Tricep Extensions: 4 sets of 10-20 reps";
                    //acesssory deadlift (Requirement 2.2.3)
                    waveA_grid[2, 2].Value = "Lat Pull Down: 4 sets of 10-12 reps\n" + "Bent Over Barbell Row: 4 sets of 10 reps\n" + " Reverse Hyperextensions: 4 sets of 12 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead (Requirement 2.2.4)
                    waveA_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Rope Upright Rows: 4 sets of 10 reps\n" + "Bent Over Dumbbell Reverse Fly: 4 sets of 10-15 reps\n" + "Behind-the-Neck Overhead Press: 4 sets of 10 reps\n";
                    break;
                    

            }



        }

        private void populate_wave_B(int option)
        {
            waveB_grid[0, 0].Value = "Day 1: " + squatExercise;
            waveB_grid[0, 1].Value = "Day 2: " + benchExercise;
            waveB_grid[0, 2].Value = "Day 3: " + deadliftExercise;
            waveB_grid[0, 3].Value = "Day 4: " + overheadExercise;

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
                    //accessory squat (Requirement 2.2.1)
                    waveB_grid[2, 0].Value = "Hack Squat: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //accessory bench (Requirement 2.2.2)
                    waveB_grid[2, 1].Value = "Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Cable Tricep Extension: 4 sets of 10-20 reps";
                    //accessory deadlift (Requirement 2.2.3)
                    waveB_grid[2, 2].Value = "Chin Up: 4 sets of 10-12 reps\n" + "Bent Over Dumbbell Row: 4 sets of 15 reps each arm\n" + "Back Raises: 4 sets of 15 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead (Requirement 2.2.4)
                    waveB_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Barbell Upright Row: 4 sets of 10 reps\n" + "Dumbbell Lateral Raises: 4 sets of 10-15 reps\n" + "Standing Barbell Curl: 4 sets of 10 reps\n";
                    break;
                //Option B
                case 1:
                    //accessory squat (Requirement 2.2.1)
                    waveB_grid[2, 0].Value = "Leg Press: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //acessory bench (Requirement 2.2.2)
                    waveB_grid[2, 1].Value = "Incline Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Lying Barbell Tricep Extensions: 4 sets of 10-20 reps";
                    //acesssory deadlift (Requirement 2.2.3)
                    waveB_grid[2, 2].Value = "Lat Pull Down: 4 sets of 10-12 reps\n" + "Bent Over Barbell Row: 4 sets of 10 reps\n" + " Reverse Hyperextensions: 4 sets of 12 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead (Requirement 2.2.4)
                    waveB_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Rope Upright Rows: 4 sets of 10 reps\n" + "Bent Over Dumbbell Reverse Fly: 4 sets of 10-15 reps\n" + "Behind-the-Neck Overhead Press: 4 sets of 10 reps\n";
                    break;


            }
        }

        private void populate_wave_C(int option)
        {
            waveC_grid[0, 0].Value = "Day 1: " + squatExercise;
            waveC_grid[0, 1].Value = "Day 2: " + benchExercise;
            waveC_grid[0, 2].Value = "Day 3: " + deadliftExercise;
            waveC_grid[0, 3].Value = "Day 4: " + overheadExercise;

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
                    //accessory squat (Requirement 2.2.1)
                    waveC_grid[2, 0].Value = "Hack Squat: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //accessory bench (Requirement 2.2.2)
                    waveC_grid[2, 1].Value = "Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Cable Tricep Extension: 4 sets of 10-20 reps";
                    //accessory deadlift (Requirement 2.2.3)
                    waveC_grid[2, 2].Value = "Chin Up: 4 sets of 10-12 reps\n" + "Bent Over Dumbbell Row: 4 sets of 15 reps each arm\n" + "Back Raises: 4 sets of 15 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead (Requirement 2.2.4)
                    waveC_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Barbell Upright Row: 4 sets of 10 reps\n" + "Dumbbell Lateral Raises: 4 sets of 10-15 reps\n" + "Standing Barbell Curl: 4 sets of 10 reps\n";
                    break;
                //Option B
                case 1:
                    //accessory squat (Requirement 2.2.1)
                    waveC_grid[2, 0].Value = "Leg Press: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //acessory bench (Requirement 2.2.2)
                    waveC_grid[2, 1].Value = "Incline Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Lying Barbell Tricep Extensions: 4 sets of 10-20 reps";
                    //acesssory deadlift (Requirement 2.2.3)
                    waveC_grid[2, 2].Value = "Lat Pull Down: 4 sets of 10-12 reps\n" + "Bent Over Barbell Row: 4 sets of 10 reps\n" + " Reverse Hyperextensions: 4 sets of 12 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead (Requirement 2.2.4)
                    waveC_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Rope Upright Rows: 4 sets of 10 reps\n" + "Bent Over Dumbbell Reverse Fly: 4 sets of 10-15 reps\n" + "Behind-the-Neck Overhead Press: 4 sets of 10 reps\n";
                    break;


            }

        }

        private void populate_wave_D(int option)
        {
            waveD_grid[0, 0].Value = "Day 1: " + squatExercise;
            waveD_grid[0, 1].Value = "Day 2: " + benchExercise;
            waveD_grid[0, 2].Value = "Day 3: " + deadliftExercise;
            waveD_grid[0, 3].Value = "Day 4: " + overheadExercise;

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
                    //accessory squat (Requirement 2.2.1)
                    waveD_grid[2, 0].Value = "Hack Squat: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //accessory bench (Requirement 2.2.2)
                    waveD_grid[2, 1].Value = "Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Cable Tricep Extension: 4 sets of 10-20 reps";
                    //accessory deadlift (Requirement 2.2.3)
                    waveD_grid[2, 2].Value = "Chin Up: 4 sets of 10-12 reps\n" + "Bent Over Dumbbell Row: 4 sets of 15 reps each arm\n" + "Back Raises: 4 sets of 15 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead (Requirement 2.2.4)
                    waveD_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Barbell Upright Row: 4 sets of 10 reps\n" + "Dumbbell Lateral Raises: 4 sets of 10-15 reps\n" + "Standing Barbell Curl: 4 sets of 10 reps\n";
                    break;
                //Option B
                case 1:
                    //accessory squat (Requirement 2.2.1)
                    waveD_grid[2, 0].Value = "Leg Press: 4 sets of 10-20 reps\n" + "Leg Extension: 4 sets of 10-30 reps\n" + "Leg Curl: 4 sets of 10-15 reps\n" + "Weighted Sit Up: 4 sets of 10 reps";
                    //acessory bench (Requirement 2.2.2)
                    waveD_grid[2, 1].Value = "Incline Dumbbell Bench Press: 4 sets of 10-20 reps\n" + "Weighted Dip: 4 sets of 8-15 reps\n" + "Dumbbell Flyes: 4 sets of 12 reps\n" + "Lying Barbell Tricep Extensions: 4 sets of 10-20 reps";
                    //acesssory deadlift (Requirement 2.2.3)
                    waveD_grid[2, 2].Value = "Lat Pull Down: 4 sets of 10-12 reps\n" + "Bent Over Barbell Row: 4 sets of 10 reps\n" + " Reverse Hyperextensions: 4 sets of 12 reps\n" + "Hanging Leg Raises: 4 sets of 15 reps";
                    //accessory overhead (Requirement 2.2.4)
                    waveD_grid[2, 3].Value = "Seated Dumbbell Press: 4 sets of 10 reps\n" + "Rope Upright Rows: 4 sets of 10 reps\n" + "Bent Over Dumbbell Reverse Fly: 4 sets of 10-15 reps\n" + "Behind-the-Neck Overhead Press: 4 sets of 10 reps\n";
                    break;


            }
        }


        private void printClick(object sender, EventArgs e)
        {
            printForm.PrinterSettings.DefaultPageSettings.Landscape = true;
            printForm.Print(Form.ActiveForm, Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly);
        }

                    
    }
}
