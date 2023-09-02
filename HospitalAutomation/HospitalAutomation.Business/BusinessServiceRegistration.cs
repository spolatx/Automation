using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Business.Managers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public class BusinessServiceRegistration
    {
        ServiceProvider serviceProvider;
        public BusinessServiceRegistration()
        {
            serviceProvider = new ServiceCollection().AddScoped<IGenderService, GenderManager>()
                .BuildServiceProvider();
        }
        // Microsoft  

        //new ServiceCollection

        public IGenderService GetGenderServiceInstance()
        {
            return serviceProvider.GetRequiredService<IGenderService>();
        }
    }
}
