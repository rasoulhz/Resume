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
	public class ExperienceService : IExperienceService
	{
		private readonly IExperienceRepository _experienceRepository;

		public ExperienceService(IExperienceRepository experienceRepository)
        {
			_experienceRepository = experienceRepository;
		}
        public async Task<List<ExperienceDTO>> GetAllExperienceDTOAsync()
		{
			List<Experience> experiences = await _experienceRepository.GetAllExperienceAsync();
			List<ExperienceDTO> experienceDTOs = new List<ExperienceDTO>();
			foreach (var experience in experiences)
			{
				experienceDTOs.Add(DTOMapping.DTOMapping.ToExperirienceDTO(experience));
			}
			return experienceDTOs;

		}
	}
}
