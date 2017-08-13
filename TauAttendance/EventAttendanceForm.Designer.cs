namespace TauAttendance
{
    partial class EventAttendanceForm
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
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.listBoxAttended = new System.Windows.Forms.ListBox();
            this.checkBoxYes = new System.Windows.Forms.CheckBox();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(12, 29);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(463, 771);
            this.listBoxNames.TabIndex = 0;
            // 
            // listBoxAttended
            // 
            this.listBoxAttended.FormattingEnabled = true;
            this.listBoxAttended.Location = new System.Drawing.Point(481, 29);
            this.listBoxAttended.Name = "listBoxAttended";
            this.listBoxAttended.Size = new System.Drawing.Size(37, 771);
            this.listBoxAttended.TabIndex = 1;
            // 
            // checkBoxYes
            // 
            this.checkBoxYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxYes.Location = new System.Drawing.Point(679, 170);
            this.checkBoxYes.Name = "checkBoxYes";
            this.checkBoxYes.Size = new System.Drawing.Size(61, 92);
            this.checkBoxYes.TabIndex = 2;
            this.checkBoxYes.Text = "Yes";
            this.checkBoxYes.UseVisualStyleBackColor = true;
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNo.Location = new System.Drawing.Point(801, 170);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(91, 92);
            this.checkBoxNo.TabIndex = 3;
            this.checkBoxNo.Text = "No";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(650, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 82);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(650, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(242, 82);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EventAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 825);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkBoxNo);
            this.Controls.Add(this.checkBoxYes);
            this.Controls.Add(this.listBoxAttended);
            this.Controls.Add(this.listBoxNames);
            this.Name = "EventAttendanceForm";
            this.Text = "EventAttendanceForm";
            this.Load += new System.EventHandler(this.EventAttendanceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.ListBox listBoxAttended;
        private System.Windows.Forms.CheckBox checkBoxYes;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}