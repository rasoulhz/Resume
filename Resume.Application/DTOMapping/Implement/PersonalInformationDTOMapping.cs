using Resume.Application.DTOMapping.Interface;
using Resume.Application.DTOs;
using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOMapping.Implement
{
    public class PersonalInformationDTOMapping : IPersonalInformationDTOMapping
    {
        public PersonalInformationDTO GetPersonalInformationDTO(PersonalInformation personalInformation)
        {
            PersonalInformationDTO personalInformationDTO= new()
            {
                Name = personalInformation.Name,
                Address = personalInformation.Address,
                JobTitle = personalInformation.JobTitle,
                Description = personalInformation.Description,
                DescriptionTitle = personalInformation.DescriptionTitle,
                PhoneNumber = personalInformation.PhoneNumber,
                BirthDate = personalInformation.BirthDate,
                WebSite = personalInformation.WebSite,
                Email = personalInformation.Email,
            };
            return personalInformationDTO;
        }
    }
}
