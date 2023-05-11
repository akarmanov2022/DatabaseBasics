using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.SqlParser.Parser;

namespace Lab2.Forms
{
    public partial class QueriesForm : Form
    {
        private static QueriesForm _queriesForm;

        private QueriesForm()
        {
            InitializeComponent();
        }

        public static QueriesForm GetForm()
        {
            if (_queriesForm == null || _queriesForm.IsDisposed)
            {
                _queriesForm = new QueriesForm();
            }
            return _queriesForm;
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            var sql = Parser.Parse(TextBoxSql.Text).Script.Sql;
            
        }
    }
}