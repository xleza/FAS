using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Core.Commands.Seminars;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.Admin.UI.Seminars.Models;

namespace FAS.Admin.UI.Seminars
{
    public partial class SeminarAttendeesForm : Form
    {
        private readonly string _seminarId;
        private readonly IQueryDao _queryDao;
        private readonly SeminarCommandService _commandService;
        private string _selectedAttendeeId;

        public SeminarAttendeesForm(string seminarId, IQueryDao queryDao, SeminarCommandService commandService)
        {
            _seminarId = seminarId;
            _queryDao = queryDao;
            _commandService = commandService;

            InitializeComponent();

#pragma warning disable 4014
            RefreshTableAsync();
#pragma warning restore 4014
        }

        private async Task RefreshTableAsync()
        {
            RemoveSeminarAttendeeBtn.Enabled = false;

            var attendees = await _queryDao.ListAsync<SeminarAttendeesListItemDto>($"SeminarId='{_seminarId}'")
                .OnError(_ => MessageBoxWrapper.Error("Can't fill seminar attendees"));

            seminarAttendeesListItemDtoBindingSource.DataSource = attendees;

            _selectedAttendeeId = attendees.FirstOrDefault()?.Id;
            if (_selectedAttendeeId != null)
            {
                RemoveSeminarAttendeeBtn.Enabled = true;
            }
        }

        private void OnAttendeesGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            _selectedAttendeeId = AttendeesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private async void OnAddSeminarAttendeeBtnClick(object sender, System.EventArgs e)
        {
            var form = new AddSeminarAttendeeForm(_seminarId, _queryDao, DependencyResolver.Resolve<SeminarCommandService>());
            form.ShowDialog();

            await RefreshTableAsync();
        }

        private async void OnRemoveSeminarAttendeeBtnClick(object sender, System.EventArgs e)
        {
            var dialogResult = MessageBoxWrapper.Confirmation($"Are you sure you want to unregister attendee {_selectedAttendeeId}");
            if (dialogResult == DialogResult.Yes)
                await _commandService.UnRegisterAttendeeAsync(new UnRegisterAttendeeAtSeminar
                {
                    Id = _seminarId,
                    AttendeeId = _selectedAttendeeId
                });

            await RefreshTableAsync();
        }
    }
}
