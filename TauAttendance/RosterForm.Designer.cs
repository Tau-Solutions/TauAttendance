namespace TauAttendance
{
    partial class RosterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPercentages = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnEditAttendance = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNames
            // 
            this.listBoxNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 20;
            this.listBoxNames.Location = new System.Drawing.Point(35, 82);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(249, 604);
            this.listBoxNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Names";
            // 
            // listBoxPercentages
            // 
            this.listBoxPercentages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPercentages.FormattingEnabled = true;
            this.listBoxPercentages.ItemHeight = 20;
            this.listBoxPercentages.Location = new System.Drawing.Point(342, 82);
            this.listBoxPercentages.Name = "listBoxPercentages";
            this.listBoxPercentages.Size = new System.Drawing.Size(83, 604);
            this.listBoxPercentages.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semseter Attendance %";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(534, 232);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(149, 63);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.Location = new System.Drawing.Point(534, 338);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(149, 63);
            this.btnDeleteMember.TabIndex = 5;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnEditAttendance
            // 
            this.btnEditAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAttendance.Location = new System.Drawing.Point(534, 448);
            this.btnEditAttendance.Name = "btnEditAttendance";
            this.btnEditAttendance.Size = new System.Drawing.Size(149, 63);
            this.btnEditAttendance.TabIndex = 6;
            this.btnEditAttendance.Text = "Edit Attendance";
            this.btnEditAttendance.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(602, 648);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Member";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 723);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditAttendance);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPercentages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNames);
            this.Name = "RosterForm";
            this.Text = "RosterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPercentages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnEditAttendance;
        private System.Windows.Forms.Button button3;
    }
}