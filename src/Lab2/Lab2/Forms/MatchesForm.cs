using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Forms
{
    public partial class MatchesForm : Form
    {
        private static MatchesForm _matchesForm;

        public MatchesForm()
        {
            InitializeComponent();
        }

        public static MatchesForm GetForm()
        {
            if (_matchesForm == null || _matchesForm.IsDisposed)
            {
                _matchesForm = new MatchesForm();
            }
            return _matchesForm;
        }

        private void MatchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.matchBindingSource.EndEdit();
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

        private void MatchesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tUSURDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.tUSURDataSet.Player);
            // TODO: This line of code loads data into the 'tUSURDataSet.MatchLineup' table. You can move, or remove it, as needed.
            this.matchLineupTableAdapter.Fill(this.tUSURDataSet.MatchLineup);
            // TODO: This line of code loads data into the 'tUSURDataSet.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.tUSURDataSet.Team);
            // TODO: This line of code loads data into the 'tUSURDataSet.MatchScore' table. You can move, or remove it, as needed.
            this.matchScoreTableAdapter.Fill(this.tUSURDataSet.MatchScore);
            // TODO: This line of code loads data into the 'tUSURDataSet.Match' table. You can move, or remove it, as needed.
            this.matchTableAdapter.Fill(this.tUSURDataSet.Match);

        }
    }
}
