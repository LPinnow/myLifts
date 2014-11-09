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
    public partial class instructForm : Form
    {
        public instructForm()
        {
            InitializeComponent();
        }

        private void backClick(object sender, EventArgs e)      //close this form, return to main form
        {
            this.Close();
        }

        private void viewVideo(object sender, EventArgs e)      //drop down menu for tutorial videos
        {
            int selection = comboBox1.SelectedIndex + 1;

            switch (selection)
            {
                case 1:
                    backSquat squatVid = new backSquat();
                    squatVid.Show();
                    break;
                case 2:
                    benchPress benchVid = new benchPress();
                    benchVid.Show();
                    break;
                case 3:
                    deadlift deadliftVid = new deadlift();
                    deadliftVid.Show();
                    break;
                case 4:
                    overheadPress opVid = new overheadPress();
                    opVid.Show();
                    break;
            }    
        }

   }
}
