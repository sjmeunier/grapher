using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grapher
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void butCalc_Click(object sender, EventArgs e)
        {
            graph1.DrawGraph(txtEquation.Text, 0.1, 0.1, 0, 0, 200, 200);
        }
    }
}
