using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FAS.Core.Commands.Sessions;
using FAS.Core.Entities;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.UI.Sessions.Models;

namespace FAS.UI.Sessions
{
    public partial class AddSessionForm : Form
    {
        private readonly IQueryDao _queryDao;
        private readonly SecurityService _securityService;
        private readonly SessionsCommandService _service;

        public AddSessionForm(IQueryDao queryDao, SecurityService securityService, SessionsCommandService service)
        {
            _queryDao = queryDao;
            _securityService = securityService;
            _service = service;

            InitializeComponent();
            FillSessions();
        }

        private void FillSessions()
        {
            var activeSessions = _queryDao.List<SessionsListItemDto>($"LecturerId = '{_securityService.CurrentLecturerId}' AND Status != '{SessionStatus.Finished}'");
            var activeSessionIds = string.Join(",", activeSessions.Select(x => $"'{x.SeminarId}'"));
            var where = $"LecturerId = '{_securityService.CurrentLecturerId}'";
            if (!string.IsNullOrWhiteSpace(activeSessionIds))
                where += $" AND Id NOT IN ({activeSessionIds})";

            var sessionsToAdd = _queryDao.List<SessionsDropDownListItemDto>(where);
            Sessions.DataSource = sessionsToAdd;
        }

        private async void OnAddSessionBtnClick(object sender, EventArgs e)
        {
            var valid = ValidateChildren(ValidationConstraints.Enabled);
            if (!valid)
                return;
            AddSessionBtn.Enabled = false;

            await _service.CreateAsync(new CreateSession
            {
                Id = Guid.NewGuid().ToString(),
                SeminarId = ((SessionsDropDownListItemDto)Sessions.SelectedItem).Id
            })
             .OnSuccess(() => MessageBoxWrapper.Info("Session created successfully"))
             .OnError(MessageBoxWrapper.Error);

            AddSessionBtn.Enabled = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SessionsValidating(object sender, CancelEventArgs e)
            => ValidateControl(
                Sessions,
                Sessions.SelectedItem != null,
                "Session is required",
                e);


        private void ValidateControl(Control ctrl, bool valid, string errorTxt, CancelEventArgs e)
        {
            if (valid)
            {
                e.Cancel = false;
                ErrorProvider.SetError(ctrl, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ctrl.Focus();
                ErrorProvider.SetError(ctrl, errorTxt);
            }
        }
    }
}
