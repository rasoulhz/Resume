using Resume.Application.DTOs;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement
{
    public class PersonalInformationService : IPersonalInformationService
    {
        private readonly IPersonalInformationRepository _repository;
        public PersonalInformationService(IPersonalInformationRepository personalInformationRepository)
        {
            _repository = personalInformationRepository;
        }
        public async Task<PersonalInformationDTO> GetPersonalInformation()
        {

            return DTOMapping.DTOMapping.ToPersonalInformationDTO(await _repository.GetPersonalInformation());
            
        }
    }
}
