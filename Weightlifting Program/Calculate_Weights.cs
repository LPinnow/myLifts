using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class calculate
    {
        public static int[] wave_A(int weight)
        {
            //Array of integers containing weights {set 1 weight, set 2 weight, set 3 weight}
            int[] wave_A = new int[3];
            int set1, set2, set3;

            weight = Convert.ToInt16(weight * .90); //calculating max is 90% of true max

            set1 = Convert.ToInt16(weight * .75);
            wave_A[0] = set1;
            set2 = Convert.ToInt16(weight * .8);
            wave_A[1] = set2;
            set3 = Convert.ToInt16(weight * .85);
            wave_A[2] = set3;

            return wave_A;
        }

        public static int[] wave_B(int weight)
        {
            //Array of integers containing weights {set 1 weight, set 2 weight, set 3 weight}
            int[] wave_B = new int[3];
            int set1, set2, set3;

            weight = Convert.ToInt16(weight * .90); //calculating max is 90% of true max

            set1 = Convert.ToInt16(weight * .8);
            wave_B[0] = set1;
            set2 = Convert.ToInt16(weight * .85);
            wave_B[1] = set2;
            set3 = Convert.ToInt16(weight * .9);
            wave_B[2] = set3;

            return wave_B;
        }

        public static int[] wave_C(int weight)
        {
            //Array of integers containing weights {set 1 weight, set 2 weight, set 3 weight}
            int[] wave_C = new int[3];
            int set1, set2, set3;

            weight = Convert.ToInt16(weight * .90); //calculating max is 90% of true max

            set1 = Convert.ToInt16(weight * .75);
            wave_C[0] = set1;
            set2 = Convert.ToInt16(weight * .85);
            wave_C[1] = set2;
            set3 = Convert.ToInt16(weight * .95);
            wave_C[2] = set3;

            return wave_C;
        }

        public static int[] wave_D(int weight)
        {
            //Array of integers containing weights {set 1 weight, set 2 weight, set 3 weight}
            int[] wave_D = new int[3];
            int set1, set2, set3;

            weight = Convert.ToInt16(weight * .90); //calculating max is 90% of true max

            set1 = Convert.ToInt16(weight * .6);
            wave_D[0] = set1;
            set2 = Convert.ToInt16(weight * .65);
            wave_D[1] = set2;
            set3 = Convert.ToInt16(weight * .7);
            wave_D[2] = set3;

            return wave_D;
        }
    }
}
