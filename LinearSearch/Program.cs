using Microsoft.Extensions.DependencyInjection;
using Bl;
using LinearSearch.Utlities;
using Domains;
using Bl.Services;
using Bl.Interfaces;

namespace LinearSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region dependency injection
            // Create a new instance of the ServiceCollection class
            var services = new ServiceCollection();

            // Register the required services and their implementations
            services.AddScoped<Bl.Interfaces.IBusinessLayer<TbNumber>, NumberService>();
            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();
            #endregion

            #region instance of UiHelper 
                UiHelper uiHelper = new UiHelper
        (
            serviceProvider.GetService<IBusinessLayer<TbNumber>>(),
            new TbNumber()

         );
                #endregion

            uiHelper.PerformLinearSearch();
            
        }
    }
}