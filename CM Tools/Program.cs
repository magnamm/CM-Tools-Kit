using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            deleteTestBooking();
            Console.ReadLine();
        }

        private const string Source = "vana-phy-cm01";
        private const string Db = "Vana_Live";
        private const string User = "sa";
        private const string Pass = "P@55word";
        public const string sqlConnectionString = @"data source=" + Source + ";initial catalog=" + Db + ";user id=" + User + ";password=" + Pass;

        public static string getToday()
        {
            return DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + " 00:00:00";
        }

        public static void deleteTestBooking()
        {
            string queryCommand = "select * from booking";

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
                Console.WriteLine("connection " + connection.State.ToString());

                try
                {
                    command.CommandText = queryCommand;

                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dataTable);
                    Console.WriteLine(dataTable.Rows.Count);
                    //target.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: " + ex.GetType().ToString() +
                        "\nMessage: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("connection " + connection.State.ToString());

                }

            }
        }
    }
}
