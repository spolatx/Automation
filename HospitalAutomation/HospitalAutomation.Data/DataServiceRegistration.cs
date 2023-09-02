using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Data
{
    internal class DataServiceRegistration
    {
        ServiceProvider serviceProvider;
        public DataServiceRegistration()
        {
            serviceProvider = new ServiceCollection().AddScoped<IGenderRepository, GenderRepository>()
               .BuildServiceProvider();
        }
        // Microsoft  

        //new ServiceCollection

        public IGenderRepository GetGenderRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IGenderRepository>();
        }

    }
}
