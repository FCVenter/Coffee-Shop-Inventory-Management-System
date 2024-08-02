using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    public static class SQL
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeetleCafData.mdf;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(connectionString);

        public static void displaySql(string sql, DataGridView dgv)
        {
            try
            { 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand(sql, conn);

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(ds, "Display");

                dgv.DataSource = ds;
                dgv.DataMember = "Display";

                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error: " + se.Message);
            }
        }

        public static void GenerateReport(string sql, RichTextBox rtxt)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                rtxt.Clear();

                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader dataReader = command.ExecuteReader();

                int[] maxLengths = CalculateMaxLengths(dataReader);
                dataReader.Close();

                // Reset the data reader
                dataReader = command.ExecuteReader();

                AddReportHeader(rtxt);
                BuildAndAddHeader(dataReader, rtxt, maxLengths);
                BuildAndAddDataRows(dataReader, rtxt, maxLengths);

                // Add "End of Report" at the end
                rtxt.AppendText("End of Report");

                dataReader.Close();
                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error: " + se.Message);
            }
            
        }

        private static int[] CalculateMaxLengths(SqlDataReader dataReader)
        {
            int[] maxLengths = new int[dataReader.FieldCount];
            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                maxLengths[i] = dataReader.GetName(i).Length;

                while (dataReader.Read())
                {
                    for (int j = 0; j < dataReader.FieldCount; j++)
                    {
                        int length;
                        if (dataReader[j] is decimal || dataReader[j] is double)
                        {
                            length = string.Format("{0:C}", dataReader[j]).Length;
                        }
                        else
                        {
                            length = dataReader[j].ToString().Length;
                        }

                        if (length > maxLengths[j])
                        {
                            maxLengths[j] = length;
                        }
                    }
                }
            }

            return maxLengths;
        }

        private static void AddReportHeader(RichTextBox rtxt)
        {
            // Add date at the start of the report
            rtxt.AppendText("REPORT:\nDate: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "\n");
        }

        private static void BuildAndAddHeader(SqlDataReader dataReader, RichTextBox rtxt, int[] maxLengths)
        {
            StringBuilder header = new StringBuilder();
            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                header.Append(dataReader.GetName(i).PadRight(maxLengths[i])).Append("\t");
            }
            rtxt.AppendText(header.ToString() + "\n");
        }

        private static void BuildAndAddDataRows(SqlDataReader dataReader, RichTextBox rtxt, int[] maxLengths)
        {
            while (dataReader.Read())
            {
                StringBuilder sb = new StringBuilder();

                // Loop over the items in the row
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    // If the data type is decimal or double, format it as currency and align to right
                    if (dataReader[i] is decimal || dataReader[i] is double)
                    {
                        var currencyValue = string.Format("{0:C}", dataReader[i]);
                        var currencySymbol = currencyValue.Substring(0, 1); // Extract the currency symbol assuming it's at the first position
                        var amount = currencyValue.Substring(1); // Extract the rest of the currency value

                        // Format to currency and pad with spaces on the left for the amount to match the maximum length
                        sb.Append(currencySymbol + amount.PadLeft(maxLengths[i] - 1)).Append("\t");
                    }
                    else
                    {
                        sb.Append(dataReader[i].ToString().PadRight(maxLengths[i])).Append("\t");
                    }
                }

                // Add the string builder's string to the RichTextBox
                rtxt.AppendText(sb.ToString() + "\n");
            }
        }

        public static void populateCombobox(ComboBox cbx, string sql)
        {
            try
            {

                // Extract column name using regular expression
                string columnName = Regex.Match(sql, @"(?<=SELECT\s)\w+").Value;

                // Extract table name using regular expression
                string tableName = Regex.Match(sql, @"(?<=FROM\s)\w+").Value;


                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand(sql, conn);

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(ds, tableName);

                cbx.DisplayMember = columnName;
                cbx.ValueMember = columnName;
                cbx.DataSource = ds.Tables[tableName];
                cbx.SelectedIndex = -1;

                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error: " + se.Message);
            }
        }

        public static string readSingleValue(string sql)
        {
            string value = "";

            try
            {
                SqlConnection conn = new SqlConnection(SQL.connectionString);
                conn.Open();


                SqlDataReader dataReader;
                SqlCommand command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    value = dataReader.GetValue(0).ToString();
                }

                conn.Close();
            }
            catch (SqlException se) // Catch exceptions for sql errors
            {
                MessageBox.Show("Error: " + se.Message);
            }

            return value;

        }

        public static void readDrinkPrices(RichTextBox rtb, string sql)
        {
            string output = "";
            try
            {
                SqlConnection conn = new SqlConnection(SQL.connectionString);
                conn.Open();


                SqlDataReader dataReader;
                SqlCommand command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    decimal price = Convert.ToDecimal(dataReader.GetValue(1));
                    string outputLine = String.Format("{0,-15}{1,5}\t{2,5}\t{3,5}\n",
                                                      dataReader.GetValue(0),  // Drink name
                                                      ((int)price),  // Small price
                                                      InventoryManagement.calculateMediumPrice(price),  // Medium price
                                                      InventoryManagement.calculateLargePrice(price));  // Large price
                    rtb.AppendText(outputLine);
                }

                conn.Close();
            }
            catch (SqlException se) // Catch exceptions for sql errors
            {
                MessageBox.Show("Error: " + se.Message);
            }

        }

        public static void readFoodPrices(RichTextBox rtb, string sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection(SQL.connectionString);
                conn.Open();


                SqlDataReader dataReader;
                SqlCommand command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    decimal price = Convert.ToDecimal(dataReader.GetValue(1));
                    string outputLine = String.Format("{0,-18}{1,5}\n",
                                                      dataReader.GetValue(0),  // Coffee name
                                                      ((int)price));  // Price
                    rtb.AppendText(outputLine);
                }


                conn.Close();
            }
            catch (SqlException se) // Catch exceptions for sql errors
            {
                MessageBox.Show("Error: " + se.Message);
            }

        }

        public static void updateRecord(string sql)
        {
            try
            {
                // Prevent reopening connection if already opened
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public static void insertRecord(string sql)
        {
            try
            {
                // Log in console for debugging purposes
                //System.Diagnostics.Debug.WriteLine(sql);

                // Prevent reopening connection if already opened
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }
    }
}
