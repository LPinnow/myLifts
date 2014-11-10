using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class calculate
    {
        /**
         * Calculation A
         * (Requirement 2.1.1)
         */
        public static int[] wave_A(int weight)
        {
            //Array of integers containing weights {set 1 weight, set 2 weight, set 3 weight}
            int[] wave_A = new int[3];
            int set1, set2, set3;
      

            weight = (int) Math.Round(weight * .90); //calculating max is 90% of true max

     
            set1 = (int)Math.Ceiling((weight * .75) / 5) * 5;   //rounding up to nearest integer divisible by 5 to reflect weights used in the gym
            wave_A[0] = set1;
            set2 = (int)Math.Ceiling((weight * .80) / 5) * 5;
            wave_A[1] = set2;
            set3 = (int)Math.Ceiling((weight * .85) / 5) * 5;
            wave_A[2] = set3;
          
            return wave_A;
        }

        /**
         * Calculation B
         * (Requirement 2.1.2)
         */
        public static int[] wave_B(int weight)
        {
            //Array of integers containing weights {set 1 weight, set 2 weight, set 3 weight}
            int[] wave_B = new int[3];
            int set1, set2, set3;

            weight = (int)Math.Round(weight * .90); //calculating max is 90% of true max


            set1 = (int)Math.Ceiling((weight * .80) / 5) * 5;   //rounding up to nearest integer divisible by 5 to reflect weights used in the gym
            wave_B[0] = set1;
            set2 = (int)Math.Ceiling((weight * .85) / 5) * 5;
            wave_B[1] = set2;
            set3 = (int)Math.Ceiling((weight * .90) / 5) * 5;
            wave_B[2] = set3;

            return wave_B;
        }

        /**
         * Calculation C
         * (Requirement 2.1.3)
         */
        public static int[] wave_C(int weight)
        {
            //Array of integers containing weights {set 1 weight, set 2 weight, set 3 weight}
            int[] wave_C = new int[3];
            int set1, set2, set3;

            weight = (int)Math.Round(weight * .90); //calculating max is 90% of true max


            set1 = (int)Math.Ceiling((weight * .75) / 5) * 5;   //rounding up to nearest integer divisible by 5 to reflect weights used in the gym
            wave_C[0] = set1;
            set2 = (int)Math.Ceiling((weight * .85) / 5) * 5;
            wave_C[1] = set2;
            set3 = (int)Math.Ceiling((weight * .95) / 5) * 5;
            wave_C[2] = set3;

            return wave_C;
        }

        /**
         * Calculation D
         * (Requirement 2.1.4)
         */
        public static int[] wave_D(int weight)
        {
            //Array of integers containing weights {set 1 weight, set 2 weight, set 3 weight}
            int[] wave_D = new int[3];
            int set1, set2, set3;

            weight = (int)Math.Round(weight * .90); //calculating max is 90% of true max


            set1 = (int)Math.Ceiling((weight * .60) / 5) * 5;   //rounding up to nearest integer divisible by 5 to reflect weights used in the gym
            wave_D[0] = set1;
            set2 = (int)Math.Ceiling((weight * .65) / 5) * 5;
            wave_D[1] = set2;
            set3 = (int)Math.Ceiling((weight * .70) / 5) * 5;
            wave_D[2] = set3;

            return wave_D;
        }
    }
}
