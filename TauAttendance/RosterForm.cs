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
    public partial class RosterForm : Form
    {
        public RosterForm()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemForm = new AddMemberForm();
            addMemForm.ShowDialog();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditAttendance_Click(object sender, EventArgs e)
        {
            MemberAttendanceForm memAttendanceForm = new MemberAttendanceForm();
            memAttendanceForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
