﻿using System.Linq;
using System.Windows.Forms;
using FAS.Core;
using FAS.Persistence;
using FAS.UI.Profile;

namespace FAS.UI
{
    public sealed class SecurityService
    {
        private readonly IQueryDao _queryDao;
        public string CurrentLecturerId { get; private set; }
        public string CurrentLecturerFullName { get; private set; }

        public SecurityService(IQueryDao queryDao)
        {
            _queryDao = queryDao;
        }

        public bool IsAuthorized()
        {
            var lecturers = _queryDao.List<ProfileListItemDto>();
            var verificationForm = new VerificationForm(
                DependencyResolver.Resolve<IFingerprintVerifier>(),
                lecturers.Select(lecturer => lecturer.FingerprintChecksum).ToList());

            var dialogResult = verificationForm.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return false;

            var currentLecturer = lecturers.First(lecturer => lecturer.FingerprintChecksum == verificationForm.VerifiedChecksum);
            CurrentLecturerId = currentLecturer.Id;
            CurrentLecturerFullName = currentLecturer.FullName;

            return true;
        }
    }
}
