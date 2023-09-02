using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Data;
using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Data.Repositories;
using HospitalAutomation.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business.Managers
{
    public class KanGrubuManager : IKanGrubuService
    {
        private readonly IKanGrubuRepository kanGrubuRepository;

        public KanGrubuManager() => kanGrubuRepository = new DataServiceRegistration().GetKanGrubuRepositoryInstance();
        public List<KanGrubuListDto> GetKanGrubuList()
        {
            var kanGrubuListDto=new List<KanGrubuListDto>();
            var kanGrubu = kanGrubuRepository.GetKanGruplari();
            foreach (var kanGruplari in kanGrubu)
            {
                var kanGruplariDto = new KanGrubuListDto();

                kanGruplariDto.Id = kanGruplari.Id;
                kanGruplariDto.KanGrubuAdi = kanGruplari.KanGrubuAdi;

                kanGrubuListDto.Add(kanGruplariDto);
            }
            return kanGrubuListDto;
        }
    }
}
