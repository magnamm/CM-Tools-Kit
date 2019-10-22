using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Booked.Views
{
    public partial class CM_Booked_View : Form
    {
        public CM_Booked_View()
        {
            InitializeComponent();
        }

        private void EnabledToggle(ToolStripButton sender)
        {
            sender.Enabled = !sender.Enabled;
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            EnabledToggle(btnCancel);
            EnabledToggle(btnSearch);
            //All empty
            if (string.IsNullOrWhiteSpace(txbClientID.Text) &&
                string.IsNullOrWhiteSpace(txbBookingID.Text) &&
                string.IsNullOrWhiteSpace(txbRecipt.Text))
            {

                string cmd = "select * from RPTR_BookingSalesbyExtraitem where BOOKINGID in (select bking_id from booking where bking_date = '" + Modules.Connection.getToday() + "' and bking_name = 'Admission Online Revenue');";

                Modules.Connection.DataRequest(dgvSummery, cmd);
            }
            else
            {
                string cmd = "select * from RPTR_BookingSalesbyExtraitem where BOOKINGID in (select bking_id from booking where bking_date = '" + Modules.Connection.getToday() + "' and bking_name = 'Admission Online Revenue');";
                Modules.Connection.DataRequest(dgvSummery, cmd);

            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            EnabledToggle(btnCancel);
            EnabledToggle(btnSearch);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            EnabledToggle(btnClear);
        }
    }
}
