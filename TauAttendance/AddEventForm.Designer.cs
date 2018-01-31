namespace TauAttendance
{
    partial class AddEventForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.txtBoxEventTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.checkBoxMandatory = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(37, 51);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(78, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "&Title:";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(37, 128);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(59, 23);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "&Date:";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // txtBoxEventTitle
            // 
            this.txtBoxEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEventTitle.Location = new System.Drawing.Point(121, 37);
            this.txtBoxEventTitle.Multiline = true;
            this.txtBoxEventTitle.Name = "txtBoxEventTitle";
            this.txtBoxEventTitle.Size = new System.Drawing.Size(444, 37);
            this.txtBoxEventTitle.TabIndex = 2;
            this.txtBoxEventTitle.TextChanged += new System.EventHandler(this.txtBoxEventTitle_TextChanged);
            // 
            // dateTimePickerEvent
            // 
            this.dateTimePickerEvent.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEvent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerEvent.Location = new System.Drawing.Point(121, 131);
            this.dateTimePickerEvent.Name = "dateTimePickerEvent";
            this.dateTimePickerEvent.Size = new System.Drawing.Size(286, 20);
            this.dateTimePickerEvent.TabIndex = 3;
            this.dateTimePickerEvent.ValueChanged += new System.EventHandler(this.dateTimePickerEvent_ValueChanged);
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEvent.Location = new System.Drawing.Point(53, 207);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(110, 44);
            this.btnSaveEvent.TabIndex = 4;
            this.btnSaveEvent.Text = "Save ";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(376, 207);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 44);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // checkBoxMandatory
            // 
            this.checkBoxMandatory.AutoSize = true;
            this.checkBoxMandatory.Location = new System.Drawing.Point(527, 133);
            this.checkBoxMandatory.Name = "checkBoxMandatory";
            this.checkBoxMandatory.Size = new System.Drawing.Size(82, 17);
            this.checkBoxMandatory.TabIndex = 6;
            this.checkBoxMandatory.Text = "Mandatory?";
            this.checkBoxMandatory.UseVisualStyleBackColor = true;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 290);
            this.Controls.Add(this.checkBoxMandatory);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.btnSaveEvent);
            this.Controls.Add(this.dateTimePickerEvent);
            this.Controls.Add(this.txtBoxEventTitle);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtBoxEventTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvent;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox checkBoxMandatory;
    }
}