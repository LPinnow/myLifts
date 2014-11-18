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
    public partial class benchPress : Form
    {
        public benchPress()
        {
            InitializeComponent();
            benchWebBrowser.Navigate("https://www.youtube.com/watch?v=GIqcXj2pAPA");
        }
    }
}
