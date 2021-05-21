using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Xdelta;
using System.IO;

namespace Newer_DS_Patcher
{
    public partial class Screen4 : UserControl
    {
        public string InputFilename;
        public string Hash;
        public string OutputFilename;

        public Screen4(string _Input, string _hash, string _Output)
        {
            InitializeComponent();

            InputFilename = _Input;
            OutputFilename = _Output;
            Hash = _hash;
        }

        private void Screen4_Load(object sender, EventArgs e)
        {
            Label_InFilePath.Text = InputFilename;
            Label_OutFilePath.Text = OutputFilename;

            this.ActiveControl = button_Start;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Label_Wait.Visible = true;
            Label_Wait.Update();

            try
            {
                FileStream Output = new FileStream(OutputFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                FileStream CheckedROMFile = new FileStream(InputFilename, FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream PatchFile = new FileStream(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\Patches\\" + Hash + ".xdelta", FileMode.Open, FileAccess.Read, FileShare.Read);

                Xdelta.Decoder Decoder = new Xdelta.Decoder(CheckedROMFile, PatchFile, Output);
                Decoder.Run();

                Output.Close();
                CheckedROMFile.Close();
                PatchFile.Close();

                this.Parent.Controls.Add(new Screen5());
                this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                Label_Wait.Visible = false;
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new Screen3(InputFilename, Hash));
            this.Parent.Controls.Remove(this);
        }
    }
}
