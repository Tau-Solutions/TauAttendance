namespace TauAttendance
{
    partial class AddMemberForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.txtBoxMemberName = new System.Windows.Forms.TextBox();
            this.labelPledgeClass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(467, 238);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 44);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEvent.Location = new System.Drawing.Point(144, 238);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(110, 44);
            this.btnSaveEvent.TabIndex = 10;
            this.btnSaveEvent.Text = "Save ";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // txtBoxMemberName
            // 
            this.txtBoxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemberName.Location = new System.Drawing.Point(212, 68);
            this.txtBoxMemberName.Multiline = true;
            this.txtBoxMemberName.Name = "txtBoxMemberName";
            this.txtBoxMemberName.Size = new System.Drawing.Size(444, 46);
            this.txtBoxMemberName.TabIndex = 8;
            // 
            // labelPledgeClass
            // 
            this.labelPledgeClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPledgeClass.Location = new System.Drawing.Point(70, 159);
            this.labelPledgeClass.Name = "labelPledgeClass";
            this.labelPledgeClass.Size = new System.Drawing.Size(117, 23);
            this.labelPledgeClass.TabIndex = 7;
            this.labelPledgeClass.Text = "&Pledge Class:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(128, 82);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 23);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "&Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 351);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.btnSaveEvent);
            this.Controls.Add(this.txtBoxMemberName);
            this.Controls.Add(this.labelPledgeClass);
            this.Controls.Add(this.labelName);
            this.Name = "AddMemberForm";
            this.Text = "AddMemberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.TextBox txtBoxMemberName;
        private System.Windows.Forms.Label labelPledgeClass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}