using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.SqlParser.Parser;
using static System.Windows.Forms.CheckState;

namespace Lab2.Controls
{
    public partial class RequestExamples : UserControl
    {
        public RequestExamples()
        {
            InitializeComponent();
        }
        
        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            var text = TextBoxSql.Text;
            var result = Parser.Parse(text);
            var errors = result.Errors.ToList();
            if (errors.Count != 0)
            {
                var message = errors.Aggregate(
                    "Errors:\n",
                    (current, error) => current + $"\t- ${error.Message}\n");
                MessageBox.Show(message, @"Exceptions!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var sql = result.Script.Sql;
                using (var connection = new SqlConnection(Properties.Settings.Default.TUSURConnectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = sql;
                    var adapter = new SqlDataAdapter();
                    if (sql.StartsWith("SELECT", true, CultureInfo.CurrentCulture))
                    {
                        adapter.SelectCommand = command;
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DataGridViewSql.DataSource = dataTable;
                    }
                    else
                    {
                        var rows = command.ExecuteNonQuery();
                        MessageBox.Show($@"The number of rows affected: {rows}", @"Successful", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Error: {exception.Message}",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}