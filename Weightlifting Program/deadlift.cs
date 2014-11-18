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
    public partial class deadlift : Form
    {
        public deadlift()
        {
            InitializeComponent();
            dlWebBrowser.Navigate("http://www.youtube.com/watch?v=u6UgD1H_AXw");
        }
    }
}
