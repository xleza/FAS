using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.Admin.UI.Seminars.Models;

namespace FAS.Admin.UI.Seminars
{
    public partial class SeminarsForm : Form
    {
        private readonly IQueryDao _queryDao;
        private string _selectedSeminarId;

        public SeminarsForm(IQueryDao queryDao)
        {
            _queryDao = queryDao;
            InitializeComponent();

#pragma warning disable 4014
            RefreshTableAsync();
#pragma warning restore 4014
        }

        private async Task RefreshTableAsync()
        {
            var seminars = await _queryDao.ListAsync<SeminarsListItemDto>()
                .OnError(_ => MessageBoxWrapper.Error("Can't fill seminars Table"));

            seminarsListItemDtoBindingSource.DataSource = seminars;

            _selectedSeminarId = seminars.FirstOrDefault()?.Id;
            if (_selectedSeminarId != null)
            {
                SeminarAttendeesBtn.Enabled = true;
            }
        }

        private void OnSeminarsGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            _selectedSeminarId = SeminarsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private async void OnSeminarAddBtnClick(object sender, EventArgs e)
        {
            var addForm = DependencyResolver.Resolve<AddSeminarForm>();
            var dialog = addForm.ShowDialog();
            if (dialog == DialogResult.OK)
                await RefreshTableAsync();
        }

        private async void OnRefreshSeminarsBtnClick(object sender, EventArgs e)
        {
            await RefreshTableAsync();
        }

        private void OnSeminarAttendeesBtnClick(object sender, EventArgs e)
        {
            var seminarStudentsFrom = new SeminarAttendeesForm(_selectedSeminarId, _queryDao, DependencyResolver.Resolve<SeminarCommandService>());
            seminarStudentsFrom.ShowDialog();
        }
    }
}
