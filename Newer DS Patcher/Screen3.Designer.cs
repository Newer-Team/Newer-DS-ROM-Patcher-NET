namespace Newer_DS_Patcher
{
    partial class Screen3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_SelectOutput = new System.Windows.Forms.Label();
            this.label_Explanation1 = new System.Windows.Forms.Label();
            this.label_NewDS = new System.Windows.Forms.Label();
            this.label_NewerDS = new System.Windows.Forms.Label();
            this.label_NewerDS2 = new System.Windows.Forms.Label();
            this.button_Choose = new System.Windows.Forms.Button();
            this.Label_Status = new System.Windows.Forms.Label();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.label_Explanation2 = new System.Windows.Forms.Label();
            this.label_Explanation3 = new System.Windows.Forms.Label();
            this.label_Explanation4 = new System.Windows.Forms.Label();
            this.label_Explanation5 = new System.Windows.Forms.Label();
            this.label_Prompt1 = new System.Windows.Forms.Label();
            this.label_Prompt2 = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Textbox_OutPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_SelectOutput
            // 
            this.label_SelectOutput.AutoSize = true;
            this.label_SelectOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SelectOutput.ForeColor = System.Drawing.Color.MediumBlue;
            this.label_SelectOutput.Location = new System.Drawing.Point(19, 30);
            this.label_SelectOutput.Name = "label_SelectOutput";
            this.label_SelectOutput.Size = new System.Drawing.Size(184, 21);
            this.label_SelectOutput.TabIndex = 20;
            this.label_SelectOutput.Text = "Select output ROM file";
            // 
            // label_Explanation1
            // 
            this.label_Explanation1.AutoSize = true;
            this.label_Explanation1.Location = new System.Drawing.Point(20, 70);
            this.label_Explanation1.Name = "label_Explanation1";
            this.label_Explanation1.Size = new System.Drawing.Size(173, 13);
            this.label_Explanation1.TabIndex = 24;
            this.label_Explanation1.Text = "Choose a file name for your copy of";
            // 
            // label_NewDS
            // 
            this.label_NewDS.AutoSize = true;
            this.label_NewDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NewDS.Location = new System.Drawing.Point(314, 86);
            this.label_NewDS.Name = "label_NewDS";
            this.label_NewDS.Size = new System.Drawing.Size(116, 13);
            this.label_NewDS.TabIndex = 27;
            this.label_NewDS.Text = "New Super Mario Bros.";
            // 
            // label_NewerDS
            // 
            this.label_NewerDS.AutoSize = true;
            this.label_NewerDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NewerDS.Location = new System.Drawing.Point(187, 70);
            this.label_NewerDS.Name = "label_NewerDS";
            this.label_NewerDS.Size = new System.Drawing.Size(143, 13);
            this.label_NewerDS.TabIndex = 29;
            this.label_NewerDS.Text = "Newer Super Mario Bros. DS";
            // 
            // label_NewerDS2
            // 
            this.label_NewerDS2.AutoSize = true;
            this.label_NewerDS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NewerDS2.Location = new System.Drawing.Point(101, 124);
            this.label_NewerDS2.Name = "label_NewerDS2";
            this.label_NewerDS2.Size = new System.Drawing.Size(143, 13);
            this.label_NewerDS2.TabIndex = 31;
            this.label_NewerDS2.Text = "Newer Super Mario Bros. DS";
            // 
            // button_Choose
            // 
            this.button_Choose.Location = new System.Drawing.Point(23, 145);
            this.button_Choose.Name = "button_Choose";
            this.button_Choose.Size = new System.Drawing.Size(75, 23);
            this.button_Choose.TabIndex = 33;
            this.button_Choose.Text = "Choose...";
            this.button_Choose.UseVisualStyleBackColor = true;
            this.button_Choose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Status.Location = new System.Drawing.Point(23, 172);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(100, 12);
            this.Label_Status.TabIndex = 35;
            this.Label_Status.Text = "Please enter a file path.";
            // 
            // button_Next
            // 
            this.button_Next.Enabled = false;
            this.button_Next.Location = new System.Drawing.Point(384, 375);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 36;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(303, 375);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 37;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label_Explanation2
            // 
            this.label_Explanation2.AutoSize = true;
            this.label_Explanation2.Location = new System.Drawing.Point(328, 70);
            this.label_Explanation2.Name = "label_Explanation2";
            this.label_Explanation2.Size = new System.Drawing.Size(132, 13);
            this.label_Explanation2.TabIndex = 38;
            this.label_Explanation2.Text = "or leave it as the default to";
            // 
            // label_Explanation3
            // 
            this.label_Explanation3.AutoSize = true;
            this.label_Explanation3.Location = new System.Drawing.Point(22, 86);
            this.label_Explanation3.Name = "label_Explanation3";
            this.label_Explanation3.Size = new System.Drawing.Size(173, 13);
            this.label_Explanation3.TabIndex = 39;
            this.label_Explanation3.Text = "\"Newer Super Mario Bros. DS.nds\"";
            // 
            // label_Explanation4
            // 
            this.label_Explanation4.AutoSize = true;
            this.label_Explanation4.Location = new System.Drawing.Point(190, 86);
            this.label_Explanation4.Name = "label_Explanation4";
            this.label_Explanation4.Size = new System.Drawing.Size(127, 13);
            this.label_Explanation4.TabIndex = 40;
            this.label_Explanation4.Text = "in the same folder as your";
            // 
            // label_Explanation5
            // 
            this.label_Explanation5.AutoSize = true;
            this.label_Explanation5.Location = new System.Drawing.Point(425, 86);
            this.label_Explanation5.Name = "label_Explanation5";
            this.label_Explanation5.Size = new System.Drawing.Size(35, 13);
            this.label_Explanation5.TabIndex = 41;
            this.label_Explanation5.Text = "ROM.";
            // 
            // label_Prompt1
            // 
            this.label_Prompt1.AutoSize = true;
            this.label_Prompt1.Location = new System.Drawing.Point(20, 124);
            this.label_Prompt1.Name = "label_Prompt1";
            this.label_Prompt1.Size = new System.Drawing.Size(86, 13);
            this.label_Prompt1.TabIndex = 30;
            this.label_Prompt1.Text = "ROM file to save";
            // 
            // label_Prompt2
            // 
            this.label_Prompt2.AutoSize = true;
            this.label_Prompt2.Location = new System.Drawing.Point(241, 124);
            this.label_Prompt2.Name = "label_Prompt2";
            this.label_Prompt2.Size = new System.Drawing.Size(21, 13);
            this.label_Prompt2.TabIndex = 42;
            this.label_Prompt2.Text = "as:";
            // 
            // Textbox_OutPath
            // 
            this.Textbox_OutPath.Location = new System.Drawing.Point(104, 147);
            this.Textbox_OutPath.Name = "Textbox_OutPath";
            this.Textbox_OutPath.Size = new System.Drawing.Size(354, 20);
            this.Textbox_OutPath.TabIndex = 43;
            this.Textbox_OutPath.TextChanged += new System.EventHandler(this.textBox_OutPath_TextChanged);
            // 
            // scr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Textbox_OutPath);
            this.Controls.Add(this.label_Prompt2);
            this.Controls.Add(this.label_Explanation5);
            this.Controls.Add(this.label_Explanation4);
            this.Controls.Add(this.label_Explanation3);
            this.Controls.Add(this.label_Explanation2);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.button_Choose);
            this.Controls.Add(this.label_NewerDS2);
            this.Controls.Add(this.label_Prompt1);
            this.Controls.Add(this.label_NewerDS);
            this.Controls.Add(this.label_NewDS);
            this.Controls.Add(this.label_Explanation1);
            this.Controls.Add(this.label_SelectOutput);
            this.Name = "scr3";
            this.Size = new System.Drawing.Size(479, 412);
            this.Load += new System.EventHandler(this.scr3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SelectOutput;
        private System.Windows.Forms.Label label_Explanation1;
        private System.Windows.Forms.Label label_NewDS;
        private System.Windows.Forms.Label label_NewerDS;
        private System.Windows.Forms.Label label_NewerDS2;
        private System.Windows.Forms.Button button_Choose;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label_Explanation2;
        private System.Windows.Forms.Label label_Explanation3;
        private System.Windows.Forms.Label label_Explanation4;
        private System.Windows.Forms.Label label_Explanation5;
        private System.Windows.Forms.Label label_Prompt1;
        private System.Windows.Forms.Label label_Prompt2;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TextBox Textbox_OutPath;
    }
}
