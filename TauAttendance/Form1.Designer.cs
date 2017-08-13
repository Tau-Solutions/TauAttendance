namespace TauAttendance
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnPastEvents = new System.Windows.Forms.Button();
            this.btnViewRoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 175);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tau \r\nAttendance\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(321, 221);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(688, 88);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnPastEvents
            // 
            this.btnPastEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPastEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastEvents.Location = new System.Drawing.Point(321, 332);
            this.btnPastEvents.Name = "btnPastEvents";
            this.btnPastEvents.Size = new System.Drawing.Size(688, 88);
            this.btnPastEvents.TabIndex = 2;
            this.btnPastEvents.Text = "View Past Events";
            this.btnPastEvents.UseVisualStyleBackColor = true;
            // 
            // btnViewRoster
            // 
            this.btnViewRoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoster.Location = new System.Drawing.Point(321, 445);
            this.btnViewRoster.Name = "btnViewRoster";
            this.btnViewRoster.Size = new System.Drawing.Size(688, 88);
            this.btnViewRoster.TabIndex = 3;
            this.btnViewRoster.Text = "View Roster";
            this.btnViewRoster.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 752);
            this.Controls.Add(this.btnViewRoster);
            this.Controls.Add(this.btnPastEvents);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.label1);
            this.Name = "HomeForm";
            this.Text = "Tau Attendance";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnPastEvents;
        private System.Windows.Forms.Button btnViewRoster;
    }
}

