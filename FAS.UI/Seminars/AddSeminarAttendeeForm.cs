using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Core.Commands.Seminars;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.UI.Seminars.Models;

namespace FAS.UI.Seminars
{
    public partial class AddSeminarAttendeeForm : Form
    {
        private readonly string _seminarId;
        private readonly IQueryDao _queryDao;
        private readonly SeminarCommandService _commandService;
        private ListViewItem _selectedSeminarAttendee;

        public AddSeminarAttendeeForm(string seminarId, IQueryDao queryDao, SeminarCommandService commandService)
        {
            InitializeComponent();

            _seminarId = seminarId;
            _queryDao = queryDao;
            _commandService = commandService;

#pragma warning disable 4014
            FillAttendeesAsync();
#pragma warning restore 4014
        }

        private async Task FillAttendeesAsync()
        {
            var seminarAttendeesToAdd = new List<AddSeminarAttendeesListItemDto>();
            try
            {
                var existingAttendees = await _queryDao.ListAsync<SeminarAttendeesListItemDto>($"SeminarId = '{_seminarId}'");
                var where = existingAttendees.Count == 0 ? "" : $"Id NOT IN ({string.Join(",", existingAttendees.Select(x => $"'{x.Id}'"))})";

                seminarAttendeesToAdd = await _queryDao.ListAsync<AddSeminarAttendeesListItemDto>(where)
                   .OnError(_ => MessageBoxWrapper.Error("Can't fill seminar attendees"));
            }
            catch (Exception)
            {
                MessageBoxWrapper.Error("Can't fill seminar attendees");
            }

            foreach (var attendee in seminarAttendeesToAdd ?? new List<AddSeminarAttendeesListItemDto>())
            {
                Attendees.Items.Add(new ListViewItem(new[] { attendee.Id, attendee.FullName, attendee.BirthDate.ToString() })
                {
                    Tag = attendee
                });
            }
        }

        private void OnAttendeesItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_selectedSeminarAttendee != null)
            {
                Attendees.ItemCheck -= OnAttendeesItemCheck;
                _selectedSeminarAttendee.Checked = false;
                Attendees.ItemCheck += OnAttendeesItemCheck;
            }

            _selectedSeminarAttendee = null;
            Ok.Enabled = false;

            if (e.NewValue != CheckState.Checked) return;

            _selectedSeminarAttendee = Attendees.Items[e.Index];
            Ok.Enabled = true;
        }

        private async void OnOkClick(object sender, EventArgs e)
        {
            var attendeeToAdd = (AddSeminarAttendeesListItemDto)_selectedSeminarAttendee.Tag;
            var dialogResult = MessageBoxWrapper.Confirmation($"Are you sure you want to register attendee {attendeeToAdd.Id} in seminar");
            if (dialogResult != DialogResult.Yes)
                return;

            await _commandService.RegisterAttendeeAsync(new RegisterAttendeeAtSeminar
            {
                Id = _seminarId,
                AttendeeId = attendeeToAdd.Id
            })
                .OnSuccess(() => MessageBoxWrapper.Info("Attendee registered successfully"))
                .OnError(_ => MessageBoxWrapper.Error("Attendee registration failed"));

            Close();
        }
    }
}
