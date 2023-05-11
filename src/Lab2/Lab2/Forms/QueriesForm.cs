using System.Windows.Forms;

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
    }
}