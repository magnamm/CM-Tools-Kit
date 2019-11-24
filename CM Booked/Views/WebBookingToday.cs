using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Booked.Views
{
    public partial class WebBookingToday : Form
    {

        public string Date { get; set; } = Modules.Connection.getToday();
        public WebBookingToday()
        {
            InitializeComponent();
            inputDate.Value = DateTime.Today;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            
            Date = Modules.Connection.getToday(inputDate.Value);
            string order = " order by BOOKINGID , EXTRAITEMNAME";
            string value, date;

            if (chkSimple.Checked)
            {
                value = "distinct bookingid,EntityID,ENTITYNAME, EXTRAITEMNAME,EXTRAITEMQTY, UNITCOSTCHARGED, BALANCEOWING ";
            }
            else
            {
                value = " * ";
            }

            if (chkBooked.Checked)
            {
                date = " USAGEDATE = '" + Date + "' ";
            }
            else
            {
                date = " BOOKINGID in (select bking_id from booking where bking_date = '" + Date + "') ";
            }

            txbQuery.Text = @"select " + value + " from RPTR_BookingSalesbyExtraitem where " + date + " and bookingtype =  '%Admission - Online Revenue' and EntityID!=1001785 " + order + ";";

            //txbQuery.Text = @"select * from RPTR_BookingSalesbyExtraitem "
            dgvSummery.DataSource = Modules.Connection.DataTableRequest(txbQuery.Text);
            dgvSummery.AutoResizeColumns();
        }
    }
}
