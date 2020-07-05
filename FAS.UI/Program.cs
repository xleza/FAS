using System;
using System.Configuration;
using System.Windows.Forms;
using FAS.Core;
using FAS.Core.Persistence;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.Scanner.DigitalPersona;
using Ninject;
using Ninject.Modules;

namespace FAS.UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DependencyResolver.Wire(new NinjectModuleImpl());


            Application.Run(new Main());
        }

        private class NinjectModuleImpl : NinjectModule
        {
            public override void Load()
            {
                var connectionString = ConfigurationManager.ConnectionStrings["FAS"].ToString();
                var device = ConfigurationManager.AppSettings["FingerprintDevice"];
                switch (device)
                {
                    case "DigitalPersona":
                        {
                            Bind(typeof(IFingerprintEnroller)).To<Enroller>();
                            break;
                        }
                    default: throw new NotImplementedException($"Device {device} not implemented");
                }

                var studentsDao = new StudentsDao(connectionString);
                var lecturersDao = new LecturersDao(connectionString);

                Bind(typeof(IStudentsDao)).ToConstant(studentsDao);
                Bind(typeof(StudentsDao)).ToConstant(studentsDao);

                Bind(typeof(ILecturerDao)).ToConstant(lecturersDao);
                Bind(typeof(LecturersDao)).ToConstant(lecturersDao);

                Bind(typeof(StudentsCommandService)).ToSelf();
            }
        }
    }

    public static class DependencyResolver
    {
        private static IKernel _ninjectKernel;

        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }
}
