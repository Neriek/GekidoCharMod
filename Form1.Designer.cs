namespace GekidoCharMod
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.charSelect = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.procStatus = new System.Windows.Forms.Label();
            this.setChar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // charSelect
            // 
            this.charSelect.FormattingEnabled = true;
            this.charSelect.Items.AddRange(new object[] {
            "Travis",
            "Gorilla",
            "Michelle",
            "Tetsuo",
            "Kobuchi",
            "Ushi",
            "Kintaro",
            "Angela",
            "Akujin",
            "Mechi",
            "Ciccio",
            "Koji",
            "Kuji",
            "Yushin Pro",
            "Ishigame",
            "Shadow",
            "Shuju",
            "Kintarog"});
            this.charSelect.Location = new System.Drawing.Point(12, 57);
            this.charSelect.Name = "charSelect";
            this.charSelect.Size = new System.Drawing.Size(121, 21);
            this.charSelect.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // procStatus
            // 
            this.procStatus.AutoSize = true;
            this.procStatus.ForeColor = System.Drawing.Color.Red;
            this.procStatus.Location = new System.Drawing.Point(87, 29);
            this.procStatus.Name = "procStatus";
            this.procStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.procStatus.Size = new System.Drawing.Size(96, 13);
            this.procStatus.TabIndex = 1;
            this.procStatus.Text = "ePSXe Not Found!";
            this.procStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setChar
            // 
            this.setChar.AutoSize = true;
            this.setChar.Location = new System.Drawing.Point(154, 59);
            this.setChar.Name = "setChar";
            this.setChar.Size = new System.Drawing.Size(91, 17);
            this.setChar.TabIndex = 2;
            this.setChar.Text = "Set Character";
            this.setChar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(259, 105);
            this.Controls.Add(this.setChar);
            this.Controls.Add(this.procStatus);
            this.Controls.Add(this.charSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Gekido Char Mod";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox charSelect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label procStatus;
        private System.Windows.Forms.CheckBox setChar;
    }
}

