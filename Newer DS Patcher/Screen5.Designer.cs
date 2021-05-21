namespace Newer_DS_Patcher
{
    partial class Screen5
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
            this.Label_AllDone = new System.Windows.Forms.Label();
            this.Label_Enjoy = new System.Windows.Forms.Label();
            this.button_Finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_AllDone
            // 
            this.Label_AllDone.AutoSize = true;
            this.Label_AllDone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_AllDone.ForeColor = System.Drawing.Color.MediumBlue;
            this.Label_AllDone.Location = new System.Drawing.Point(16, 21);
            this.Label_AllDone.Name = "Label_AllDone";
            this.Label_AllDone.Size = new System.Drawing.Size(78, 21);
            this.Label_AllDone.TabIndex = 22;
            this.Label_AllDone.Text = "All done!";
            // 
            // Label_Enjoy
            // 
            this.Label_Enjoy.AutoSize = true;
            this.Label_Enjoy.Location = new System.Drawing.Point(17, 61);
            this.Label_Enjoy.Name = "Label_Enjoy";
            this.Label_Enjoy.Size = new System.Drawing.Size(243, 13);
            this.Label_Enjoy.TabIndex = 26;
            this.Label_Enjoy.Text = "Patching complete! We hope you enjoy the game.";
            // 
            // button_Finish
            // 
            this.button_Finish.Location = new System.Drawing.Point(384, 375);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(75, 23);
            this.button_Finish.TabIndex = 36;
            this.button_Finish.Text = "Finish";
            this.button_Finish.UseVisualStyleBackColor = true;
            this.button_Finish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // Screen5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_Finish);
            this.Controls.Add(this.Label_Enjoy);
            this.Controls.Add(this.Label_AllDone);
            this.Name = "Screen5";
            this.Size = new System.Drawing.Size(479, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_AllDone;
        private System.Windows.Forms.Label Label_Enjoy;
        private System.Windows.Forms.Button button_Finish;
    }
}
