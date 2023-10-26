using System;
using System.Windows.Forms;

namespace Lab2.Forms
{
    public partial class LeagueForm : Form
    {
        private static LeagueForm _leagueForm;

        public LeagueForm()
        {
            InitializeComponent();
        }

        private void LeagueTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.leagueTableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tUSURDataSet);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LeagueForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tUSURDataSet.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.tUSURDataSet.Team);
            // TODO: This line of code loads data into the 'tUSURDataSet.LeagueTable' table. You can move, or remove it, as needed.
            this.leagueTableTableAdapter.Fill(this.tUSURDataSet.LeagueTable);
        }

        public static LeagueForm GetForm()
        {
            if (_leagueForm == null || _leagueForm.IsDisposed)
            {
                _leagueForm = new LeagueForm();
            }

            return _leagueForm;
        }

        private void ToolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var text = ToolStripTextBoxSearch.Text;
            if (text is "")
            {
                this.leagueTableBindingSource.Filter = "";
                this.leagueTableTableAdapter.Fill(this.tUSURDataSet.LeagueTable);
                return;
            }

            if (int.TryParse(text, out var id))
            {
                this.leagueTableBindingSource.Filter = $"Id={id}";
            }
        }
    }
}