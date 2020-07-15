using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Core;
using FAS.Core.Commands.Sessions;
using FAS.Core.Entities;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.UI.Sessions.Models;
using LiveCharts;
using LiveCharts.Wpf;

namespace FAS.UI.Sessions
{
    public partial class SessionDashboardForm : Form
    {
        private readonly IQueryDao _queryDao;
        private readonly SessionsCommandService _commandService;
        private readonly IFingerprintVerifier _verifier;
        private readonly SessionDetailedDto _session;
        private readonly List<RegisteredAttendeeAtSeminar> _registeredAttendees;
        private List<SessionAttendeesListItemDto> _sessionAttendingAttendees;
        private List<(string id, string name)> _sessionNotAttendingAttendees;

        private bool _listen = true;

        private readonly ListView _registeredAttendeesListView;
        private readonly ListView _attendingAttendeesListView;
        private readonly ListView _notAttendingAttendeesListView;


        public SessionDashboardForm(string sessionId, IQueryDao queryDao, SessionsCommandService commandService, IFingerprintVerifier verifier)
        {
            _queryDao = queryDao;
            _commandService = commandService;
            _verifier = verifier;

            _session = queryDao.Get<SessionDetailedDto>(sessionId);
            _registeredAttendees = queryDao.List<RegisteredAttendeeAtSeminar>($"SeminarId = '{_session.SeminarId}'");
            RefreshSessionAttendees();

            _verifier.Capture += OnCapture;
            _verifier.Connect += OnConnect;
            _verifier.Disconnect += OnDisconnect;

            _registeredAttendeesListView = CreateRegisteredAttendeesListView();
            _attendingAttendeesListView = CreateAttendingAttendeesListView();
            _notAttendingAttendeesListView = CreateNotAttendingAttendeesListView();

            Controls.Add(_registeredAttendeesListView);
            Controls.Add(_attendingAttendeesListView);
            Controls.Add(_notAttendingAttendeesListView);

            _registeredAttendeesListView.Hide();
            _attendingAttendeesListView.Hide();
            _notAttendingAttendeesListView.Hide();

            InitializeComponent();
            SeminarLbl.Text = _session.Name;

            CalculateMetrics();
        }

        private void OnCapture(object sender, Bitmap e)
        {
            if (!_listen)
                return;
            _listen = false;
            Invoke(new Action(async () =>
            {
                FingerprintBox.Image = e;

                Log("Fingerprint Captured");

                await Task.Delay(500);
                var verified = false;
                foreach (var item in _registeredAttendees)
                {
                    if (!_verifier.Verify(item.FingerprintChecksum)) continue;

                    var alreadyVerified = _sessionAttendingAttendees.Any(x => x.Id == item.Id);
                    if (alreadyVerified)
                    {
                        Log($"Student: {item.FullName} is already verified");
                        break;
                    }

                    Log($"Student: {item.FullName} verified");

                    await _commandService.AddAttendeeAsync(new AddAttendeeAtSession
                    {
                        Id = item.Id,
                        SessionId = _session.Id
                    });

                    verified = true;
                    RefreshSessionAttendees();
                    CalculateMetrics();
                    break;
                }

                if (!verified)
                    Log("Fingerprint not verified");

                FingerprintBox.Image = null;
                _listen = true;
            }));
        }

        private void OnConnect(object sender, EventArgs e) => Log("Fingerprint scanner connected");

        private void OnDisconnect(object sender, EventArgs e) => Log("Fingerprint scanner disconnected");

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            _verifier.Connect -= OnConnect;
            _verifier.Disconnect -= OnDisconnect;
            _verifier.Capture -= OnCapture;
            _verifier.Dispose();
        }

        private void OnRegisteredCountLblMouseHover(object sender, EventArgs e)
        {
            _registeredAttendeesListView.Show();
            _registeredAttendees.ForEach(attendee =>
            {
                _registeredAttendeesListView.Items.Add(new ListViewItem(new[] { attendee.Id, attendee.FullName }));
            });
        }
        private void OnRegisteredCountLblMouseLeave(object sender, EventArgs e)
        {
            _registeredAttendeesListView.Items.Clear();
            _registeredAttendeesListView.Hide();
        }

        private void OnAttendingCountLblMouseHover(object sender, EventArgs e)
        {
            _attendingAttendeesListView.Show();
            _sessionAttendingAttendees.ForEach(attendee =>
            {
                _attendingAttendeesListView.Items.Add(new ListViewItem(new[] { attendee.Id, attendee.FullName, attendee.AttendeeStartTime.ToString("MM/dd HH:mm") }));
            });
        }
        private void OnAttendingCountLblMouseLeave(object sender, EventArgs e)
        {
            _attendingAttendeesListView.Items.Clear();
            _attendingAttendeesListView.Hide();
        }

        private void OnNotAttendingCountLblMouseHover(object sender, EventArgs e)
        {
            _notAttendingAttendeesListView.Show();
            _sessionNotAttendingAttendees.ForEach(attendee =>
            {
                _notAttendingAttendeesListView.Items.Add(new ListViewItem(new[] { attendee.id, attendee.name }));
            });
        }
        private void OnNotAttendingCountLblMouseLeave(object sender, EventArgs e)
        {
            _notAttendingAttendeesListView.Items.Clear();
            _notAttendingAttendeesListView.Hide();
        }

        private void RefreshSessionAttendees()
        {
            _sessionAttendingAttendees = _queryDao.List<SessionAttendeesListItemDto>($"SessionId = '{_session.Id}'");
            _sessionNotAttendingAttendees = _registeredAttendees
                .Where(x => _sessionAttendingAttendees.All(xx => xx.Id != x.Id))
                .Select(x => (x.Id, x.FullName))
                .ToList();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            var diff = DateTime.Now - _session.StartTime;
            ElapsedMinutesLbl.Text = $"{(int)diff.TotalMinutes}:{diff.Seconds}";
        }

        private void Log(string message) => Invoke(new Action(() => LogList.Items.Add(message)));

        private void CalculateMetrics()
        {
            var registeredCount = _registeredAttendees.Count;
            var attendingCount = _sessionAttendingAttendees.Count;
            var notAttending = registeredCount - attendingCount;

            RegisteredCountLbl.Text = registeredCount.ToString();
            AttendingCountLbl.Text = attendingCount.ToString();
            NotAttendingCountLbl.Text = notAttending.ToString();

            AttendanceChart.Series.Clear();

            AttendanceChart.Series.Add(new PieSeries
            {
                Title = "Attending",
                Values = new ChartValues<int> { attendingCount },
                DataLabels = true,
                LabelPoint = point => $"{point.Y} ({point.Participation:P})"
            });

            AttendanceChart.Series.Add(new PieSeries
            {
                Title = "Not Attending",
                Values = new ChartValues<int> { notAttending },
                DataLabels = true,
                LabelPoint = point => $"{point.Y} ({point.Participation:P})"
            });
        }

        private static ListView CreateRegisteredAttendeesListView()
        {
            var listView = new ListView { Size = new Size(226, 220), Location = new Point(50, 192), View = View.Details };
            listView.Columns.Add(new ColumnHeader
            {
                Name = "Id",
                Text = "Personal Id",
                Width = 108
            });
            listView.Columns.Add(new ColumnHeader
            {
                Name = "FullName",
                Text = "Full Name",
                Width = 108
            });

            return listView;
        }

        private static ListView CreateAttendingAttendeesListView()
        {
            var listView = new ListView { Size = new Size(354, 220), Location = new Point(300, 192), View = View.Details };
            listView.Columns.Add(new ColumnHeader
            {
                Name = "Id",
                Text = "Personal Id",
                Width = 108
            });
            listView.Columns.Add(new ColumnHeader
            {
                Name = "FullName",
                Text = "Full Name",
                Width = 108

            });
            listView.Columns.Add(new ColumnHeader
            {
                Name = "AttendeeStartTime",
                Text = "Attendee Start Time",
                Width = 133

            });
            return listView;
        }

        private static ListView CreateNotAttendingAttendeesListView()
        {
            var listView = new ListView { Size = new Size(226, 220), Location = new Point(581, 192), View = View.Details };
            listView.Columns.Add(new ColumnHeader
            {
                Name = "Id",
                Text = "Personal Id",
                Width = 108
            });
            listView.Columns.Add(new ColumnHeader
            {
                Name = "FullName",
                Text = "Full Name",
                Width = 108
            });

            return listView;
        }

        private async void OnStopSessionBtnClick(object sender, EventArgs e)
        {
            if (_session.Status == SessionStatus.Finished.ToString())
                return;

            var confirmed = MessageBoxWrapper.Confirmation("Are you sure you want to finish seminar?") == DialogResult.Yes;
            if (!confirmed)
                return;

            await _commandService.FinishAsync(new FinishSession
            {
                Id = _session.Id
            })
            .OnSuccess(() => MessageBoxWrapper.Info("Session has been finished"))
            .OnError(_ => MessageBoxWrapper.Error("Failed to finish session"));
            Close();
        }
    }
}
