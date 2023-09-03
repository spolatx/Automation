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
            serviceProvider = new ServiceCollection().AddScoped<IGenderRepository, GenderRepository>()
             .AddScoped<IKanGrubuRepository,KanGrubuRepository>().AddScoped<IPoliklinikRepository,PoliklinikRepository>()
             .AddScoped<IDoktorRepository,DoktorRepository>()
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
        public IPoliklinikRepository GetPoliklinikRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IPoliklinikRepository>();
        }
        public IDoktorRepository GetDoktorRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IDoktorRepository>();
        }
    }
}
