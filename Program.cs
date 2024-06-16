using ListEmployee.Interface;
using ListEmployee.MyService;
using Microsoft.Extensions.DependencyInjection;

namespace ListEmployee
{
    internal static class Program
    {

        public static IServiceCollection Services { get; } = new ServiceCollection()
                .AddSingleton<ICustomCollection, CustomCollection>()
                .AddTransient<IService, Service>()
                .AddTransient<IApplicationContext, ApplicationContext>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {

            using var serviceProvider = Services.BuildServiceProvider();

            ICustomCollection collection = serviceProvider.GetRequiredService<ICustomCollection>();
            IService service = serviceProvider.GetRequiredService<IService>();


            collection.Statistics.Add("@Status", "");
            collection.Statistics.Add("@FromDate", new DateTime(1970, 01, 01));
            collection.Statistics.Add("@ToDate", DateTime.Now);




            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ListEmployee());


        }
    }
}