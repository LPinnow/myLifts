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
    public partial class triExtend : Form
    {
        public triExtend()
        {
            InitializeComponent();
            extendWebBrowser.Navigate("https://www.youtube.com/watch?v=4xFGszK2LDc");
        }
    }
}
