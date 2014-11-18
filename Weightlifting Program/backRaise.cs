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
    public partial class backRaise : Form
    {
        public backRaise()
        {
            InitializeComponent();
            brWebBrowser.Navigate("https://www.youtube.com/watch?v=vx0jZBEmZcE");
        }
    }
}
