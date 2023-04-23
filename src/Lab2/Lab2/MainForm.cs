using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Forms;

namespace Lab2
{
    public sealed partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ContextMenuStrip = ContextMenuStripMain;
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(@"(C)ТУСУР, КИБЭВС, Карманов Арсений Викторович, группа 571-2, 2023", @"О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(@"Вы хотите закрыть программу?",
                           @"Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                       DialogResult.Yes;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void TeamsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            TeamsForm.GetForm().ShowDialog();
        }

        private void PlayersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            PlayersForm.GetForm().ShowDialog();
        }

        private void MatchesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MatchesForm.GetForm().ShowDialog();
        }

        private void LeagueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LeagueForm.GetForm().ShowDialog();
        }
    }
}