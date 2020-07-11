using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FAS.Core;
using FAS.Persistence;
using FAS.UI.Lecturers.Models;

namespace FAS.UI
{
    public sealed class SecurityService
    {
        private readonly IQueryDao _queryDao;
        public string CurrentLecturer { get; private set; }

        public SecurityService(IQueryDao queryDao)
        {
            _queryDao = queryDao;
        }

        public bool IsAuthorized()
        {
            var lecturers = _queryDao.List<LecturersListItemDto>();
            var verificationForm = new VerificationForm(
                DependencyResolver.Resolve<IFingerprintVerifier>(),
                lecturers.Select(lecturer => lecturer.FingerprintChecksum).ToList());

            var dialogResult = verificationForm.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return false;

            var currentLecturer = lecturers.First(lecturer => lecturer.FingerprintChecksum == verificationForm.VerifiedChecksum);
            CurrentLecturer = currentLecturer.Id;

            return true;
        }
    }
}
