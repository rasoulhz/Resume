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
    public class AboutMeService : IAboutMeService
    {
        private readonly IAboutMeRepository _aboutMeRepository;

        public AboutMeService(IAboutMeRepository aboutMeRepository)
        {
            _aboutMeRepository = aboutMeRepository;
        }

        public async Task<List<AboutMeDTO>> GetAboutMeListAsync()
        {
            List<AboutMe> aboutMeList = await _aboutMeRepository.GetAboutMeListAsync();
            List<AboutMeDTO> aboutMeListDTO = new List<AboutMeDTO>();
            foreach (var aboutMe in aboutMeList)
            {
                aboutMeListDTO.Add(DTOMapping.DTOMapping.ToAboutMeDTO(aboutMe));
            }
            return aboutMeListDTO;
        }
    }
}
