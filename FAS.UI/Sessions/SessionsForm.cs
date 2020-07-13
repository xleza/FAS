using System;
using System.Windows.Forms;
using FAS.Persistence;
using FAS.UI.Sessions.Models;

namespace FAS.UI.Sessions
{
    public partial class SessionsForm : Form
    {
        private readonly IQueryDao _queryDao;

        public SessionsForm(IQueryDao queryDao)
        {
            _queryDao = queryDao;

            InitializeComponent();
            RefreshSeminars();
        }

        private void RefreshSeminars()
        {
            try
            {
                SessionsGrid.DataSource = _queryDao.List<SessionsListItemDto>();
            }
            catch (Exception)
            {
                MessageBoxWrapper.Error("Failed to fetch sessions");
            }
        }

        private void OnSessionAddBtnClick(object sender, EventArgs e)
        {
            var addSessionForm = DependencyResolver.Resolve<AddSessionForm>();
            addSessionForm.ShowDialog();

            RefreshSeminars();
        }

        private void OnRefreshSessionBtnClick(object sender, EventArgs e)
        {
            RefreshSeminars();
        }
    }
}
