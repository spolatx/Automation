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
    public class DataServiceRegistration
    {
        ServiceProvider serviceProvider;
        public DataServiceRegistration()
        {
            serviceProvider = new ServiceCollection().AddScoped<IGenderRepository, GenderRepository>().AddScoped<IKanGrubuRepository,KanGrubuRepository>()
               .BuildServiceProvider();
        }
        // Microsoft  

        //new ServiceCollection

        public IGenderRepository GetGenderRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IGenderRepository>();
        }
        public IKanGrubuRepository GetKanGrubuRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IKanGrubuRepository>();
        }

    }
}
