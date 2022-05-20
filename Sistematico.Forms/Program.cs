using DepreciationDBApp.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sistematico.Applications.Interfaces;
using Sistematico.Applications.Services;
using Sistematico.Domain.Entities;
using Sistematico.Domain.Interfaces;
using Sistematico.Forms;
using Sistematico.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico.Forms
{
    static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddEnvironmentVariables().Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            services.AddDbContext<PepitoSchoolContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped<IStudenDbContext, PepitoSchoolContext>();
            services.AddScoped<IStudentModel, EFStudentRepository>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<Form1>();

            using (var serviceScope = services.BuildServiceProvider())
            {
                var main = serviceScope.GetRequiredService<Form1>();
                Application.Run(main);
            }
        }
    }
}
