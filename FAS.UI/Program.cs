using System;
using System.Configuration;
using System.Windows.Forms;
using FAS.Core;
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


            Application.Run(new Form1());
        }

        private class NinjectModuleImpl : NinjectModule
        {
            public override void Load()
            {
                var device = ConfigurationManager.AppSettings["FingerprintDevice"];
                switch (device)
                {
                    case "DigitalPersona":
                        {
                            Bind(typeof(IEnroller)).To(typeof(Enroller));
                            break;
                        }
                    default: throw new NotImplementedException($"Device {device} not implemented");
                }
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
