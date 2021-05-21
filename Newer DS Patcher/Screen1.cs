using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Newer_DS_Patcher
{
    public partial class Screen1 : UserControl
    {
        public Screen1()
        {
            InitializeComponent();
        }

        private void scr1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Button_Next;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new Screen2(""));
            this.Parent.Controls.Remove(this);
        }

        private void Link_NewerTeam_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://newerteam.com");
        }

        private void Link_GNU_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gnu.org/licenses/");
        }
    }
}
