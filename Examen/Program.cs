using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*var builder = new ContainerBuilder();
            builder.RegisterType<BinaryEmpleadoRepository>().As<IEmpleadoModel>();
            builder.RegisterType<EmpleadoServices>().As<IEmpleadoServices>();
            var container = builder.Build();*/
            //Application.Run(new Form1());
            //Application.Run(new EmpleadoForm(container.Resolve<IEmpleadoServices>()));
        }
    }
}
