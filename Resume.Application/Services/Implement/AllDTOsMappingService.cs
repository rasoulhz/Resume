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
		private readonly IEducationService _educationService;
		private readonly IExperienceService _experienceService;

		public AllDTOsMappingService(IPersonalInformationService personalInformationService,
            IAboutMeService aboutMeService,
            IEducationService educationService,
            IExperienceService experienceService
            )
        {
            _personalService = personalInformationService;
            _aboutMeService = aboutMeService;
			_educationService = educationService;
			_experienceService = experienceService;
		}
        public async Task<AllDTOs> GetAllDTOsAsync()
        {
            AllDTOs allDTO=new();

            allDTO.PersonalInformationDTO = await _personalService.GetPersonalInformation();
            allDTO.aboutMeDTO = await _aboutMeService.GetAboutMeListAsync();
            allDTO.educationDTO = await _educationService.GetAllEducationDTOAsync();
            allDTO.experiencesDTO = await _experienceService.GetAllExperienceDTOAsync();

            return allDTO ;
        }
    }
}
