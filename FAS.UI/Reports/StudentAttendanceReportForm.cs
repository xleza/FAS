using System;
using System.Windows.Forms;
using FAS.Persistence;
using FAS.UI.Reports.Models;

namespace FAS.UI.Reports
{
    public partial class StudentAttendanceReportForm : Form
    {
        private readonly IQueryDao _queryDao;
        private readonly SecurityService _securityService;

        public StudentAttendanceReportForm(IQueryDao queryDao, SecurityService securityService)
        {
            _queryDao = queryDao;
            _securityService = securityService;
            InitializeComponent();

            SeminarsComboBox.DataSource = queryDao.List<SeminarsListItemDto>();
        }

        private void AttendanceReportForm_Load(object sender, EventArgs e)
        {

            ReportViewer.RefreshReport();
        }

        private async void OnRefreshReportBtnClick(object sender, EventArgs e)
        {
            if (SeminarsComboBox.SelectedItem == null)
                return;

            var reportData = await _queryDao.ListAsync<StudentsAttendanceReportDto>($"SeminarId = '{(SeminarsComboBox.SelectedItem as SeminarsListItemDto)?.Id}'");
            studentsAttendanceReportDtoBindingSource.DataSource = reportData;
            ReportViewer.RefreshReport();
        }
    }
}
