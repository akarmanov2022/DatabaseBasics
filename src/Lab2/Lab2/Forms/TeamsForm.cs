using System;
using System.Windows.Forms;

namespace Lab2.Forms
{
    public partial class TeamsForm : Form
    {
        private static TeamsForm _teamsForm;

        public static TeamsForm GetForm()
        {
            if (_teamsForm == null || _teamsForm.IsDisposed) _teamsForm = new TeamsForm();
            return _teamsForm;
        }

        public TeamsForm()
        {
            InitializeComponent();
        }

        private void TeamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.teamBindingSource.EndEdit();
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

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tUSURDataSet.MatchScore' table. You can move, or remove it, as needed.
            this.matchScoreTableAdapter.Fill(this.tUSURDataSet.MatchScore);
            // TODO: This line of code loads data into the 'tUSURDataSet.Match' table. You can move, or remove it, as needed.
            this.matchTableAdapter.Fill(this.tUSURDataSet.Match);
            // TODO: This line of code loads data into the 'tUSURDataSet.MatchLineup' table. You can move, or remove it, as needed.
            this.matchLineupTableAdapter.Fill(this.tUSURDataSet.MatchLineup);
            // TODO: This line of code loads data into the 'tUSURDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.tUSURDataSet.Player);
            // TODO: This line of code loads data into the 'tUSURDataSet.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.tUSURDataSet.Team);

        }

        protected override void OnShown(EventArgs e)
        {
            Activate();
            base.OnShown(e);
        }
    }
}
