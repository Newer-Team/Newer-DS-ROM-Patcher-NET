using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Newer_DS_Patcher
{
    public partial class Screen2 : UserControl
    {
        private string hash = "";

        public Screen2(string _path)
        {
            InitializeComponent();
            if (_path != "")
                TextBox_InPath.Text = _path;
        }

        private void scr2_Load(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Nintendo DS ROM Files (*.nds)|*.nds|All files (*.*)|*.*";
            this.ActiveControl = Button_Choose;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new Screen1());
            this.Parent.Controls.Remove(this);
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox_InPath.Text = OpenFileDialog.FileName;
                DoChecks();
            }
        }

        private void textBox_InPath_TextChanged(object sender, EventArgs e)
        {
            DoChecks();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new Screen3(TextBox_InPath.Text, hash));
            this.Parent.Controls.Remove(this);
        }

        private void DoChecks()
        {
            string Path = TextBox_InPath.Text;

            // See if path contains slashes.
            if ((!Path.Contains("/")) && (!Path.Contains("\\")))
            {
                SetStatus(false, "Please enter a full path, not just a filename.", Color.Red);
                return;
            }

            // See if path is just a directory.
            if (Directory.Exists(Path))
            {
                FileAttributes fa = File.GetAttributes(Path);
                if ((fa & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    SetStatus(false, "Please enter a full path, not just a directory.", Color.Red);
                    return;
                }
            }

            // See if the file exists.
            if (!File.Exists(Path))
            {
                SetStatus(false, "The file doesn't exist.", Color.Red);
                return;
            }

            FileInfo fi = new FileInfo(Path);
            long Filesize = fi.Length;

            // Check if filesize is below 512 bytes.
            if (Filesize < 512)
            {
                SetStatus(false, "This is not a ROM File.", Color.Red);
                return;
            }

            // Get data from file
            byte[] Padding = new byte[7];
            byte[] NintendoLogo = new byte[157];
            byte[] Header = new byte[15];
            byte[] ActualHeader = { 0x4E, 0x45, 0x57, 0x20, 0x4D, 0x41, 0x52, 0x49, 0x4F, 0x00, 0x00, 0x00, 0x41, 0x32, 0x44 };

            using (BinaryReader reader = new BinaryReader(new FileStream(Path, FileMode.Open)))
            {
                reader.BaseStream.Seek(21, SeekOrigin.Begin);
                reader.Read(Padding, 0, 7);
                reader.BaseStream.Seek(192, SeekOrigin.Begin);
                reader.Read(NintendoLogo, 0, 157);
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                reader.Read(Header, 0, 15);
            }

            // Check if padding is blank, like it is in all NDS roms.
            foreach (byte b in Padding)
            {
                if (b != 0x0)
                {
                    SetStatus(false, "This is not a ROM File.", Color.Red);
                    return;
                }
            }

            // Check Nintendo logo hash.
            SHA256 sha = SHA256.Create();
            if (BitConverter.ToString(sha.ComputeHash(NintendoLogo)).Replace("-", "").ToLowerInvariant() != "a07b35ac13a40de9682fc24b4ded05b717da632fb621253e38cafec5471a1cce")
            {
                SetStatus(false, "This is not a ROM File.", Color.Red);
                return;
            }

            // Check if header contains "NEW MARIO A2D"
            for (int i = 0; i < Header.Length; i++)
            {
                if (Header[i] != ActualHeader[i])
                {
                    SetStatus(false, "This is not a New Super Mario Bros. ROM.", Color.Red);
                    return;
                }
            }

            // Compute MD5 hash of entire ROM.
            var md5 = MD5.Create();
            using (var stream = File.OpenRead(Path))
            {
                hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
            }

            // See if we have a patch like that.
            if (!File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/Patches/" + hash + ".xdelta"))
            {
                SetStatus(false, "This ROM file isn't supported.", Color.Red);
                return;
            }
            else
            {
                SetStatus(true, "Excellent! Click \"Next\" to proceed...", Color.Green);
            }
        }

        private void SetStatus(bool enable, string message, Color colour)
        {
            Button_Next.Enabled = enable;
            Label_Status.ForeColor = colour;
            Label_Status.Text = message;
            return;
        }
    }
}
