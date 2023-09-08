using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Business.Managers;
using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Dtos;
using HospitalAutomation.Entities;
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
                .AddScoped<IIlService,IlManager>()
                .AddScoped<IIlceService,IlceManager>()
                .AddScoped<IHastaKabulService, HastaKabulManager>()
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
        public IIlService GetIlServiceInstance()
        {
            return serviceProvider.GetRequiredService<IIlService>();
        }
        public IIlceService GetIlceServiceInstance()
        {
            return serviceProvider.GetRequiredService<IIlceService>();
        }
        public IHastaKabulService GetHastaKabulServiceInstance()
        {
            return serviceProvider.GetRequiredService<IHastaKabulService>();
        }
    }

}
