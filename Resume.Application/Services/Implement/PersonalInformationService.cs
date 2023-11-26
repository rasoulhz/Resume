using Resume.Application.DTOMapping.Interface;
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
        private readonly IPersonalInformationRepository _service;
        private readonly IPersonalInformationDTOMapping _mapper;
        public PersonalInformationService(IPersonalInformationRepository personalInformationRepository
            , IPersonalInformationDTOMapping personalInformationDTOMapping)
        {
            _service = personalInformationRepository;
            _mapper = personalInformationDTOMapping;
        }
        public async Task<PersonalInformationDTO> GetPersonalInformation()
        {

            return _mapper.GetPersonalInformationDTO(await _service.GetPersonalInformation());
        }
    }
}
