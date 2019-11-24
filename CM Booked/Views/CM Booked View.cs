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
        private string ClientID, BookingID, ReceiptNo;
        public CM_Booked_View()
        {
            InitializeComponent();

            foreach(ToolStripMenuItem item in MenuView.DropDownItems)
            {
                item.Checked = true;
            }

            txbClientID.Items.Add("1042233");
            txbClientID.Items.Add("1043113");
            txbClientID.Items.Add("1002114");
        }

        private void EnabledToggle(ToolStripButton sender)
        {
            sender.Enabled = !sender.Enabled;
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //EnabledToggle(btnCancel);
            //EnabledToggle(btnSearch);
            //All empty
            findBooking();
            //if (string.IsNullOrWhiteSpace(ClientID) &&
            //    string.IsNullOrWhiteSpace(BookingID) &&
            //    string.IsNullOrWhiteSpace(ReceiptNo))
            //{

            //    string cmd = "select * from RPTR_BookingSalesbyExtraitem where BOOKINGID in (select bking_id from booking where bking_date = '" + Modules.Connection.getToday() + "' and bking_name = 'Admission Online Revenue');";
            //    Modules.Connection.DataRequest(dgvSummery, cmd);
            //}
            //else
            //{
            //    string cmd = "select * from RPTR_BookingSalesbyExtraitem where BOOKINGID in " +
            //        "(select bking_id from booking where bking_date = '" + Modules.Connection.getToday() + 
            //        "' and bking_name = 'Admission Online Revenue');";
            //    Modules.Connection.DataRequest(dgvSummery, cmd);

            //}

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

        private void MenuItemSummary_Click(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "Summary":
                    dgvSummery.Visible = MenuItemSummary.Checked;
                    break;
                case "Booking":
                    dgvBooking.Visible = MenuItemBooking.Checked;
                    break;
                case "Payment":
                    dgvPayment.Visible = MenuItemPayment.Checked;
                    break;
                case "Booking Pay":
                    dgvBookingPay.Visible = MenuItemBookingPay.Checked;
                    break;
                case "Booking Extra":
                    dgvBookingExtra.Visible = MenuItemBookingExtra.Checked;
                    break;
                case "Booking Audit":
                    dgvBookingAudit.Visible = MenuItemBookingEdit.Checked;
                    break;
                case "RS Rcuse":
                    dgvRsrcuse.Visible = MenuItemRsRcuse.Checked;
                    break;
                case "Booking Client":
                    dgvBookingClient.Visible = MenuItemBookingClient.Checked;
                    break;
                case "Transaction":
                    dgvTransaction.Visible = MenuItemTransaction.Checked;
                    break;
                case "Trandet":
                    dgvTrandet.Visible = MenuItemTrandet.Checked;
                    break;
                default:
                    break;
            }

        }

        private void TxbClientID_TextChanged(object sender, EventArgs e)
        {
            ClientID = txbClientID.Text;
        }

        private void TxbBookingID_TextChanged(object sender, EventArgs e)
        {
            BookingID = txbBookingID.Text;
        }

        private void TxbClientID_Validating(object sender, CancelEventArgs e)
        {
            //ValidateName(TxbClientID);
            //if (this.Text != "something")
            //{
            //    //e.Cancel = true;
            //    MessageBox.Show("input something");
            //}
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            WebBookingToday webBookingToday = new WebBookingToday();
            webBookingToday.Show();
        }

        //private bool ValidateName(ToolStripComboBox input)
        //{
        //bool bStatus = true;
        //if (input.Text == "")
        //{
        //    errorProvider.SetError(input, "Please enter your Name");
        //    bStatus = false;
        //}
        //else
        //    errorProvider.SetError(input, "");
        //return bStatus;
        //}

        private void TxbRecipt_TextChanged(object sender, EventArgs e)
        {
            ReceiptNo = txbRecipt.Text;
        }

        private void findBooking()
        {
            string declare;
            string Summery, Booking, BookingAudit, BookingClient, BookingExtra,
                BookingPay, Payment, Rsrcuse, Trandet, Transaction;

            if (!string.IsNullOrWhiteSpace( ClientID))
            {
                Summery = @"select * from RPTR_BookingSalesbyExtraitem where BOOKINGID in (select bking_id from booking where clintid like '%" + ClientID + "%');";
            }
            //else if (!string.IsNullOrWhiteSpace(BookingID))
            //{
            //    Summery = @"select * from RPTR_BookingSalesbyExtraitem where BOOKINGID like '%" + BookingID + "%';";

            //}
            else
            {
                Summery = "select * from RPTR_BookingSalesbyExtraitem where BOOKINGID in (select bking_id from booking where bking_date = '" + Modules.Connection.getToday() + "' and bking_name = 'Admission Online Revenue');";

            }
            if (!string.IsNullOrWhiteSpace(BookingID))
            {
                declare = "DECLARE @booking Table (ID int) insert @booking(ID) values(" + BookingID + ")";
                Booking = declare + " select * from booking where bking_id in (select ID from @booking);";
                BookingAudit = declare + " select * from BookingAudit where BookingID in (select ID from @booking);";
                BookingClient = declare + " select * from bkngclnt where bking_id in (select ID from @booking);";
                BookingExtra = declare + " select * from bkngxtra where bking_id in (select ID from @booking);";
                BookingPay = declare + " select * from bkngpay where bking_id in (select ID from @booking);";
                Payment = declare + " select * from payments where bking_id in (select ID from @booking);";
                Rsrcuse = declare + " select * from rsrcuse where bking_id in (select ID from @booking);";


                Trandet = declare + " select * from Trandet where receiptno in (select distinct receiptno from Trandet where memberid in (select ID from @booking));";
                //Trandet = declare + " select * from Trandet where memberid in (select ID from @booking)";
                Transaction = declare + " select * from Transactions where receiptno in (select distinct receiptno from Transactions where bookingNo in (select ID from @booking));";
                //Transaction = declare + " select * from Transactions where bookingNo in (select ID from @booking);";

                dgvBooking.DataSource = Modules.Connection.DataTableRequest(Booking);
                dgvBooking.AutoResizeColumns();
                dgvBookingAudit.DataSource = Modules.Connection.DataTableRequest(BookingAudit);
                dgvBookingAudit.AutoResizeColumns();
                dgvBookingClient.DataSource = Modules.Connection.DataTableRequest(BookingClient);
                dgvBookingClient.AutoResizeColumns();
                dgvBookingExtra.DataSource = Modules.Connection.DataTableRequest(BookingExtra);
                dgvBookingExtra.AutoResizeColumns();
                dgvBookingPay.DataSource = Modules.Connection.DataTableRequest(BookingPay);
                dgvBookingPay.AutoResizeColumns();
                dgvPayment.DataSource = Modules.Connection.DataTableRequest(Payment);
                dgvPayment.AutoResizeColumns();
                dgvRsrcuse.DataSource = Modules.Connection.DataTableRequest(Rsrcuse);
                dgvRsrcuse.AutoResizeColumns();

                dgvTrandet.DataSource = Modules.Connection.DataTableRequest(Trandet);
                dgvTrandet.AutoResizeColumns();
                dgvTransaction.DataSource = Modules.Connection.DataTableRequest(Transaction);
                dgvTransaction.AutoResizeColumns();
            }

            if (!string.IsNullOrWhiteSpace(ReceiptNo))
            {

                Trandet = " select * from Trandet where receiptno =" + ReceiptNo + ";";
                //Trandet = declare + " select * from Trandet where memberid in (select ID from @booking)";
                Transaction = " select * from Transactions where receiptno =" + ReceiptNo + ";";
                //Transaction = declare + " select * from Transactions where bookingNo in (select ID from @booking);";

                dgvTrandet.DataSource = Modules.Connection.DataTableRequest(Trandet);
                dgvTrandet.AutoResizeColumns();
                dgvTransaction.DataSource = Modules.Connection.DataTableRequest(Transaction);
                dgvTransaction.AutoResizeColumns();
            }
            //MessageBox.Show("String : " + Summery);
            dgvSummery.DataSource = Modules.Connection.DataTableRequest(Summery);
            //throw new NotImplementedException();
            dgvSummery.AutoResizeColumns();


        }

    }
}
