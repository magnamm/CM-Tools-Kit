using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Booked.Modules
{
    class Connection
    {
        private const string Source = "vana-phy-cm01";
        private const string Db = "Vana_Live";
        private const string User = "sa";
        private const string Pass = "P@55word";
        public const string sqlConnectionString = @"data source=" + Source + ";initial catalog=" + Db + ";user id=" + User + ";password=" + Pass;
        public static string getToday()
        {
            return DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + " 00:00:00";
        }


        public static SqlConnection con = new SqlConnection(sqlConnectionString);

        public const string querySummery = @"select * from RPTR_BookingSalesbyExtraitem where BOOKINGID in (select bking_id from booking where clintid like '%1002114%');";


        public const string bookingID = null;

        public const string queryDeclareBooking = "DECLARE @booking Table (ID int) insert @booking(ID) values(" + bookingID + ")";
        public const string queryBooking = queryDeclareBooking + " select * from booking where bking_id in (select ID from @booking);";
        public const string queryBookingAudit = queryDeclareBooking + " select * from BookingAudit where BookingID in (select ID from @booking);";
        public const string queryBookingClient = queryDeclareBooking + " select * from bkngclnt where bking_id in (select ID from @booking);";
        public const string queryBookingExtra = queryDeclareBooking + " select * from bkngxtra where bking_id in (select ID from @booking);";
        public const string queryBookingPay = queryDeclareBooking + " select * from bkngpay where bking_id in (select ID from @booking);";
        public const string queryPayment = queryDeclareBooking + " select * from payments where bking_id in (select ID from @booking);";
        public const string queryRsrcuse = queryDeclareBooking + " select * from rsrcuse where bking_id in (select ID from @booking);";


        public const string queryTrandet = queryDeclareBooking + " select * from Trandet where receiptno in (select distinct receiptno from Trandet where memberid in (select ID from @booking));";
        //public string Trandet = declare + " select * from Trandet where memberid in (select ID from @booking)";
        public const string queryTransaction = queryDeclareBooking + " select * from Transactions where receiptno in (select distinct receiptno from Transactions where bookingNo in (select ID from @booking));";
        //public string Transaction = declare + " select * from Transactions where bookingNo in (select ID from @booking);";


        public static void DataRequest(DataGridView target)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet dataSet =new DataSet();
                DataTable dataTable = new DataTable();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                //command.Transaction = transaction;

                try
                {
                    command.CommandText = querySummery;
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dataTable);

                    target.DataSource = dataTable;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Commit Exception Type: "+ ex.GetType().ToString()+
                        "\nMessage: "+ ex.Message);
                }

                connection.Close();
            }
        }

        public static void DataRequest(DataGridView target,string queryCommand)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
                DataTable dataTable = new DataTable();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                //command.Transaction = transaction;

                try
                {
                    command.CommandText = queryCommand;

                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dataTable);

                    target.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Commit Exception Type: " + ex.GetType().ToString() +
                        "\nMessage: " + ex.Message);
                }

                connection.Close();
            }
        }


    }
}
