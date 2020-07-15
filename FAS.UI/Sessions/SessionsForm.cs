using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FAS.Core;
using FAS.Core.Commands.Sessions;
using FAS.Core.Entities;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.UI.Sessions.Models;

namespace FAS.UI.Sessions
{
    public partial class SessionsForm : Form
    {
        private readonly IQueryDao _queryDao;
        private readonly SecurityService _securityService;
        private readonly SessionsCommandService _commandService;
        private SessionsListItemDto _selectedSession;
        private Dictionary<string, SessionsListItemDto> _sessionsLookUp;

        public SessionsForm(IQueryDao queryDao, SecurityService securityService, SessionsCommandService commandService)
        {
            _queryDao = queryDao;
            _securityService = securityService;
            _commandService = commandService;

            InitializeComponent();
            RefreshSeminars();
        }

        private void RefreshSeminars()
        {
            try
            {
                var sessions = _queryDao.List<SessionsListItemDto>(
                        $"LecturerId = '{_securityService.CurrentLecturerId}'")
                    .OrderBy(x => x.StartTime)
                    .ToList();

                SessionsGrid.DataSource = sessions;
                _sessionsLookUp = sessions.ToDictionary(x => x.Id, x => x);
                if (sessions.Count > 0)
                {
                    _selectedSession = sessions.First();
                    EnableOrDisableButtons();
                }
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

        private void OnSessionDetailsBtnClick(object sender, EventArgs e)
        {
            var dashboardOpen = new SessionDashboardForm(_selectedSession.Id, _queryDao, _commandService, DependencyResolver.Resolve<IFingerprintVerifier>());
            dashboardOpen.ShowDialog();
            RefreshSeminars();
        }

        private async void OnStartSessionBtnClick(object sender, EventArgs e)
        {
            var confirmed = MessageBoxWrapper.Confirmation("Are you sure you want to start session?") == DialogResult.Yes;
            if (!confirmed)
                return;

            await _commandService.StartAsync(new StartSession
            {
                Id = _selectedSession.Id
            }).OnError(_ => MessageBoxWrapper.Error("Failed to start session"));

            var dashboardOpen = new SessionDashboardForm(_selectedSession.Id, _queryDao, _commandService, DependencyResolver.Resolve<IFingerprintVerifier>());
            dashboardOpen.ShowDialog();
            RefreshSeminars();
        }

        private async void OnFinishSessionBtnClick(object sender, EventArgs e)
        {
            var confirmed = MessageBoxWrapper.Confirmation("Are you sure you want to finish session?") == DialogResult.Yes;
            if (!confirmed)
                return;

            await _commandService.FinishAsync(new FinishSession
            {
                Id = _selectedSession.Id
            });

            RefreshSeminars();
        }

        private void OnSessionsGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _selectedSession = _sessionsLookUp[SessionsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()];
            EnableOrDisableButtons();
        }

        private void EnableOrDisableButtons()
        {
            StartSessionBtn.Enabled = false;
            StopSessionBtn.Enabled = false;
            SessionDetailsBtn.Enabled = false;

            var status = _selectedSession.Status;
            if (status == SessionStatus.NotStarted.ToString())
                StartSessionBtn.Enabled = true;
            else if (status == SessionStatus.Running.ToString())
            {
                SessionDetailsBtn.Enabled = true;
                StopSessionBtn.Enabled = true;
            }
        }
    }
}
