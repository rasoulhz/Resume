using Resume.Application.DTOs;
using Resume.Application.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement
{
    public class AllDTOsMappingService : IAllDTOsMappingService
    {
        private readonly IPersonalInformationService _personalService;
        private readonly IAboutMeService _aboutMeService;

        public AllDTOsMappingService(IPersonalInformationService personalInformationService, IAboutMeService aboutMeService)
        {
            _personalService = personalInformationService;
            _aboutMeService = aboutMeService;
        }
        public async Task<AllDTOs> GetAllDTOsAsync()
        {
            AllDTOs allDTO=new();

            allDTO.PersonalInformationDTO = await _personalService.GetPersonalInformation();
            allDTO.aboutMeDTO = await _aboutMeService.GetAboutMeListAsync();

            return allDTO ;
        }
    }
}
