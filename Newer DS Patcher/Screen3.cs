using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Xdelta;

namespace Newer_DS_Patcher
{
    public partial class Screen3 : UserControl
    {
        private string hash;
        private string inpath;
        private string outpath;

        public Screen3(string _path, string _hash)
        {
            InitializeComponent();
            inpath = _path;
            hash = _hash;
        }

        private void scr3_Load(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "Nintendo DS ROM Files (*.nds)|*.nds|All files (*.*)|*.*";

            outpath = Path.GetDirectoryName(inpath) + "\\Newer Super Mario Bros. DS.nds";
            Textbox_OutPath.Text = outpath;
            DoChecks();

            this.ActiveControl = button_Choose;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new Screen2(inpath));
            this.Parent.Controls.Remove(this);
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outpath = SaveFileDialog.FileName;
                Textbox_OutPath.Text = outpath;
                DoChecks();
            }
        }

        private void textBox_OutPath_TextChanged(object sender, EventArgs e)
        {
            DoChecks();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string OutputFilename = Textbox_OutPath.Text;

            if (Directory.Exists(Textbox_OutPath.Text))
            {
                FileAttributes fa = File.GetAttributes(Textbox_OutPath.Text);
                if ((fa & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    OutputFilename += "Newer Super Mario Bros. DS.nds";
                }
            }

            this.Parent.Controls.Add(new Screen4(inpath, hash, OutputFilename));
            this.Parent.Controls.Remove(this);
        }


        private void DoChecks()
        {
            string Path = Textbox_OutPath.Text;

            if (Path == "")
            {
                SetStatus(false, "Please enter a path.", Color.Red);
                return;
            }

            if (File.Exists(Path))
            {
                SetStatus(true, "Warning: This file already exists.", Color.Red);
                return;
            }

            else if (Directory.Exists(Path))
            {
                FileAttributes fa = File.GetAttributes(Path);
                if ((fa & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    if (File.Exists(Path + "Newer Super Mario Bros. DS.nds"))
                    {
                        SetStatus(true, "Warning: The resulting file already exists.", Color.Red);
                        return;
                    }
                }
            }

            else
            {
                SetStatus(true, "Great! Click \"Next\" to save the ROM.", Color.Green);
                return;
            }
        }

        private void SetStatus(bool enable, string message, Color colour)
        {
            button_Next.Enabled = enable;
            Label_Status.ForeColor = colour;
            Label_Status.Text = message;
            return;
        }
    }
}
