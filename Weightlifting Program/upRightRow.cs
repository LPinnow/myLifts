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
    public partial class upRightRow : Form
    {
        public upRightRow()
        {
            InitializeComponent();
            upRowWebBrowser.Navigate("https://www.youtube.com/watch?v=hRKgETX3I98");
        }
    }
}
