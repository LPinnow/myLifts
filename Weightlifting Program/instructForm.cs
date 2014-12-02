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
    /*
     * Instructions Form
     * Displays instructional information and tutorial videos
     * (Requirement 4.0.0 & 4.1.0)
     */
    public partial class instructForm : Form
    {
        public instructForm()
        {
            InitializeComponent();
        }

        // Back Button (Requirement 4.1.1)
        private void backClick(object sender, EventArgs e)      
        {
            this.Close();
        }

        // Squat drop down menu (Requirement 4.2.1 & 4.2.1.1)
        private void viewSquatVideo(object sender, EventArgs e)      
        {
            int squatSelection = squatDayBox.SelectedIndex + 1;

            switch (squatSelection)
            {
                case 1:
                    backSquat squatVid = new backSquat();
                    squatVid.Show();
                    break;
                case 2:
                    hackSquat hackVid = new hackSquat();
                    hackVid.Show();
                    break;
                case 3:
                    legExtension extenVid = new legExtension();
                    extenVid.Show();
                    break;
                case 4:
                    legCurl curlVid = new legCurl();
                    curlVid.Show();
                    break;
                case 5:
                    sitUp sitUpVid = new sitUp();
                    sitUpVid.Show();
                    break;
              
            }    
        }

        // Bench Press drop down menu (Requirement 4.2.1 & 4.2.1.2)
        private void viewBenchVideo(object sender, EventArgs e)         
        {
            int benchSelection = benchDayBox.SelectedIndex + 1;

            switch (benchSelection)
            {
                case 1:
                    benchPress benchVid = new benchPress();
                    benchVid.Show();
                    break;
                case 2:
                    barExtend barExtendVid = new barExtend();
                    barExtendVid.Show();
                    break;
                case 3:
                    triExtend extendVid = new triExtend();
                    extendVid.Show();                
                    break;
                case 4:
                    dbFlyes flyesVid = new dbFlyes();
                    flyesVid.Show();
                    break;
                case 5:
                    dbBench dbBenchVid = new dbBench();
                    dbBenchVid.Show();
                    break;
                case 6:     
                    inclineDb inclineVid = new inclineDb();
                    inclineVid.Show();
                    break;                  
                case 7:
                    dip dipVid = new dip();
                    dipVid.Show();
                    break;
            }    
        }

        // Deadlift drop down menu (Requirement 4.2.1 & 4.2.1.3)
        private void viewDLVideo(object sender, EventArgs e)           
        {
            int dlSelection = dlDayBox.SelectedIndex + 1;

            switch (dlSelection)
            {
                case 1:
                    deadlift dlVid = new deadlift();
                    dlVid.Show();
                    break;
                case 2:
                    backRaise backRaiseVid = new backRaise();
                    backRaiseVid.Show();
                    break;
                case 3:
                    barbellRow barbellRowVid = new barbellRow();
                    barbellRowVid.Show();
                    break;
                case 4:
                    dbRow dbRowVid = new dbRow();
                    dbRowVid.Show();
                    break;
                case 5:
                    chinUp chinUpVid = new chinUp();
                    chinUpVid.Show();
                    break;
                case 6:
                    legRaise legRaiseVid = new legRaise();
                    legRaiseVid.Show();
                    break;
                case 7:
                    latPullDown latPullDownVid = new latPullDown();
                    latPullDownVid.Show();
                    break;
                case 8:
                    reverseHyper hyperVid = new reverseHyper();
                    hyperVid.Show();
                    break;
            }
        }

        // Overhead Press drop down menu (Requirement 4.2.1 & 4.2.1.4)
        private void viewOhVideo(object sender, EventArgs e)            
        {
            int oHSelection = overHeadBox.SelectedIndex + 1;

            switch(oHSelection)
            {
                case 1:
                    overheadPress ohVideo = new overheadPress();
                    ohVideo.Show();
                    break;
                case 2:
                    upRightRow upRowVideo = new upRightRow();
                    upRowVideo.Show();
                    break;
                case 3: 
                    neckPress neckPressVideo = new neckPress();
                    neckPressVideo.Show();
                    break;
                case 4: 
                    reverseFly reverseFlyVideo = new reverseFly();
                    reverseFlyVideo.Show();
                    break;
                case 5:
                    lateralRaise lateralRaiseVideo = new lateralRaise();
                    lateralRaiseVideo.Show();
                    break;
                case 6:
                    ropeRows ropeRowsVideo = new ropeRows();
                    ropeRowsVideo.Show();
                    break;
                case 7:
                    seatedPress seatedPressVideo = new seatedPress();
                    seatedPressVideo.Show();
                    break;
            }
        }


   }
}
