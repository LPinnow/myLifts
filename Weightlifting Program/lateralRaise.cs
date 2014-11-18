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
    public partial class lateralRaise : Form
    {
        public lateralRaise()
        {
            InitializeComponent();
            lateralWebBrowser.Navigate("https://www.youtube.com/watch?v=X0qUJoAU8GM");
        }
    }
}
