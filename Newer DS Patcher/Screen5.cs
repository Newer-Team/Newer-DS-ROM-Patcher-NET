using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Newer_DS_Patcher
{
    public partial class Screen5 : UserControl
    {
        public Screen5()
        {
            InitializeComponent();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
