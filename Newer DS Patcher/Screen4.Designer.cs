namespace Newer_DS_Patcher
{
    partial class Screen4
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
            this.Label_PleaseConfirm = new System.Windows.Forms.Label();
            this.Label_Explanation = new System.Windows.Forms.Label();
            this.Label_InFilePath = new System.Windows.Forms.Label();
            this.Label_Explanation2 = new System.Windows.Forms.Label();
            this.Label_NewerDS = new System.Windows.Forms.Label();
            this.Label_Explanation3 = new System.Windows.Forms.Label();
            this.Label_OutFilePath = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.Label_Wait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_PleaseConfirm
            // 
            this.Label_PleaseConfirm.AutoSize = true;
            this.Label_PleaseConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_PleaseConfirm.ForeColor = System.Drawing.Color.MediumBlue;
            this.Label_PleaseConfirm.Location = new System.Drawing.Point(17, 22);
            this.Label_PleaseConfirm.Name = "Label_PleaseConfirm";
            this.Label_PleaseConfirm.Size = new System.Drawing.Size(122, 21);
            this.Label_PleaseConfirm.TabIndex = 21;
            this.Label_PleaseConfirm.Text = "Please confirm";
            // 
            // Label_Explanation
            // 
            this.Label_Explanation.AutoSize = true;
            this.Label_Explanation.Location = new System.Drawing.Point(18, 60);
            this.Label_Explanation.Name = "Label_Explanation";
            this.Label_Explanation.Size = new System.Drawing.Size(283, 13);
            this.Label_Explanation.TabIndex = 25;
            this.Label_Explanation.Text = "Make sure everything looks correct before clicking \"Start\".";
            // 
            // Label_InFilePath
            // 
            this.Label_InFilePath.AutoSize = true;
            this.Label_InFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_InFilePath.Location = new System.Drawing.Point(18, 97);
            this.Label_InFilePath.Name = "Label_InFilePath";
            this.Label_InFilePath.Size = new System.Drawing.Size(61, 13);
            this.Label_InFilePath.TabIndex = 26;
            this.Label_InFilePath.Text = "<Filename>";
            // 
            // Label_Explanation2
            // 
            this.Label_Explanation2.AutoSize = true;
            this.Label_Explanation2.Location = new System.Drawing.Point(18, 129);
            this.Label_Explanation2.Name = "Label_Explanation2";
            this.Label_Explanation2.Size = new System.Drawing.Size(150, 13);
            this.Label_Explanation2.TabIndex = 27;
            this.Label_Explanation2.Text = "will be used to make a copy of";
            // 
            // Label_NewerDS
            // 
            this.Label_NewerDS.AutoSize = true;
            this.Label_NewerDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_NewerDS.Location = new System.Drawing.Point(164, 129);
            this.Label_NewerDS.Name = "Label_NewerDS";
            this.Label_NewerDS.Size = new System.Drawing.Size(146, 13);
            this.Label_NewerDS.TabIndex = 32;
            this.Label_NewerDS.Text = "Newer Super Mario Bros. DS,\r\n";
            // 
            // Label_Explanation3
            // 
            this.Label_Explanation3.AutoSize = true;
            this.Label_Explanation3.Location = new System.Drawing.Point(301, 129);
            this.Label_Explanation3.Name = "Label_Explanation3";
            this.Label_Explanation3.Size = new System.Drawing.Size(122, 13);
            this.Label_Explanation3.TabIndex = 33;
            this.Label_Explanation3.Text = ", which will be saved as:";
            // 
            // Label_OutFilePath
            // 
            this.Label_OutFilePath.AutoSize = true;
            this.Label_OutFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_OutFilePath.Location = new System.Drawing.Point(18, 165);
            this.Label_OutFilePath.Name = "Label_OutFilePath";
            this.Label_OutFilePath.Size = new System.Drawing.Size(67, 13);
            this.Label_OutFilePath.TabIndex = 34;
            this.Label_OutFilePath.Text = "<Filename2>";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(384, 375);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 35;
            this.button_Start.Text = "Start!";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(303, 375);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 36;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Label_Wait
            // 
            this.Label_Wait.AutoSize = true;
            this.Label_Wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Wait.ForeColor = System.Drawing.Color.Red;
            this.Label_Wait.Location = new System.Drawing.Point(323, 348);
            this.Label_Wait.Name = "Label_Wait";
            this.Label_Wait.Size = new System.Drawing.Size(117, 13);
            this.Label_Wait.TabIndex = 37;
            this.Label_Wait.Text = "Patching, please wait...";
            this.Label_Wait.Visible = false;
            // 
            // Screen4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_Wait);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.Label_OutFilePath);
            this.Controls.Add(this.Label_NewerDS);
            this.Controls.Add(this.Label_Explanation3);
            this.Controls.Add(this.Label_Explanation2);
            this.Controls.Add(this.Label_InFilePath);
            this.Controls.Add(this.Label_Explanation);
            this.Controls.Add(this.Label_PleaseConfirm);
            this.Name = "Screen4";
            this.Size = new System.Drawing.Size(479, 412);
            this.Load += new System.EventHandler(this.Screen4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_PleaseConfirm;
        private System.Windows.Forms.Label Label_Explanation;
        private System.Windows.Forms.Label Label_InFilePath;
        private System.Windows.Forms.Label Label_Explanation2;
        private System.Windows.Forms.Label Label_NewerDS;
        private System.Windows.Forms.Label Label_Explanation3;
        private System.Windows.Forms.Label Label_OutFilePath;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label Label_Wait;
    }
}
