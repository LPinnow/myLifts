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
    public partial class legRaise : Form
    {
        public legRaise()
        {
            InitializeComponent();
            legRaiseWebBrowser.Navigate("https://www.youtube.com/watch?v=wr4-McBOJCg");
        }
    }
}
