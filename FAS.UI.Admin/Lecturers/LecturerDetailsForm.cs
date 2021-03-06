﻿using System.Windows.Forms;
using FAS.Persistence;
using FAS.UI.Admin.Lecturers.Models;

namespace FAS.UI.Admin.Lecturers
{
    public partial class LecturerDetailsForm : Form
    {
        private readonly string _id;
        private readonly IQueryDao _dao;

        public LecturerDetailsForm(string id, IQueryDao dao)
        {
            InitializeComponent();
            _id = id;
            _dao = dao;

            FillFormAsync();
        }

        private async void FillFormAsync()
        {
            var lecturer = await _dao.GetAsync<LecturerDetailsDto>(_id);
            PersonalIdValue.Text = lecturer.Id;
            FullNameValue.Text = lecturer.FullName;
            BirthDateValue.Text = lecturer.BirthDate.ToString("MM/dd/yyyy");
            ImageBox.Image = lecturer.Image.ToBitmap();
        }
    }
}
