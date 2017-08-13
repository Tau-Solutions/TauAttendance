using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TauAttendance
{
    //comment
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This method will take the data inserted into the Text Box and Date Picker
            //and build a query to insert the event into the database. We should have input 
            //checking to disallow blank or illegal characters. Prevent SQL injection
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEvent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEventTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
