using Resume.Application.DTOs;
using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOMapping.Interface
{
    public interface IPersonalInformationDTOMapping
    {
        PersonalInformationDTO GetPersonalInformationDTO(PersonalInformation personalInformation);
    }
}
