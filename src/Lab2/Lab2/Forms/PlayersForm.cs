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
    public partial class PlayersForm : Form
    {
        private static PlayersForm _playersForm;

        public PlayersForm()
        {
            InitializeComponent();
        }

        public static PlayersForm GetForm()
        {
            if (_playersForm == null || _playersForm.IsDisposed)
            {
                _playersForm = new PlayersForm();
            }
            return _playersForm;
        }

        private void PlayerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tUSURDataSet);

        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tUSURDataSet.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.tUSURDataSet.Team);
            // TODO: This line of code loads data into the 'tUSURDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.tUSURDataSet.Player);

        }

        protected override void OnShown(EventArgs e)
        {
            Activate();
            base.OnShown(e);
        }
    }
}
