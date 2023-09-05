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
                .AddScoped<IKanGrubuService,KanGrubuManager>().AddScoped<IPoliklinikService,PoliklinikManager>()
                .AddScoped<IDoktorService,DoktorManager>().AddScoped<IHastalarService,HastalarManager>()
                .BuildServiceProvider();
        }
        // Microsoft  

        //new ServiceCollection

        public IGenderService GetGenderServiceInstance()
        {
            return serviceProvider.GetRequiredService<IGenderService>();
        }
        public IKanGrubuService GetKanGrubuServiceInstance()
        {
            return serviceProvider.GetRequiredService<IKanGrubuService>();
        }
        public IPoliklinikService GetPoliklinikServiceInstance()
        {
            return serviceProvider.GetRequiredService<IPoliklinikService>();
        }
        public IDoktorService GetDoktorServiceInstance()
        {
            return serviceProvider.GetRequiredService<IDoktorService>();
        }
        public IHastalarService GetHastalarServiceInstance()
        {
            return serviceProvider.GetRequiredService<IHastalarService>();
        }
    }
}
