using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Documents;
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
            //AddComplements();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DependencyResolver.Wire(new NinjectModuleImpl());

            Application.Run(DependencyResolver.Resolve<Main>());
        }


        class Data
        {
            public DateTime Date { get; set; }
            public string DayOfWeek { get; set; }
            public decimal Value { get; set; }
        }
        private static IEnumerable<Data> AddComplements()
        {
            var data = new List<Data>
            {
                new Data
                {
                    Date = new DateTime(2020,7,7),
                    Value = 40
                },
                new Data
                {
                    Date = new DateTime(2020,7,9),
                    Value = 40
                },
                new Data
                {
                    Date = new DateTime(2020,7,11),
                    Value = 40
                }
            };

            var dateToCheck = DateTime.Now.AddDays(-7);
            for (var i = 0; i < 7; i++)
            {
                var exists = data.Any(x => x.Date.Date == dateToCheck.Date);

                if (!exists)
                {
                    data.Add(new Data
                    {
                        Date = dateToCheck,
                        Value = 0
                    });
                }
                dateToCheck = dateToCheck.AddDays(1);
            }

            return data.OrderBy(x => x.Date);
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
                            Bind(typeof(IFingerprintVerifier)).To<Verifier>();
                            break;
                        }
                    default: throw new NotImplementedException($"Device {device} not implemented");
                }

                var queryDao = new QueryDao(connectionString);

                Bind(typeof(IQueryDao)).ToConstant(queryDao);

                Bind(typeof(IStudentsDao)).ToConstant(new StudentsDao(connectionString));

                Bind(typeof(ILecturerDao)).ToConstant(new LecturersDao(connectionString));

                Bind(typeof(ISeminarDao)).ToConstant(new SeminarsDao(connectionString));

                Bind(typeof(ISeminarSessionDao)).ToConstant(new SessionsDao(connectionString));

                Bind(typeof(SecurityService)).ToConstant(new SecurityService(queryDao));


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
