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
    public partial class reverseFly : Form
    {
        public reverseFly()
        {
            InitializeComponent();
            reverseFlyWebBrowser.Navigate("https://www.youtube.com/watch?v=_1uZD-I3qw8");
        }
    }
}
