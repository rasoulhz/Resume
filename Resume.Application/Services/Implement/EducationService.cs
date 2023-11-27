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
	public class EducationService : IEducationService
	{
		private readonly IEducationRepository _educationRepository;

		public EducationService(IEducationRepository educationRepository)
        {
			_educationRepository = educationRepository;
		}

		public async Task<List<EducationDTO>> GetAllEducationDTOAsync()
		{
			List<Education> educations = await _educationRepository.GetAllEducationsAsync();
			List<EducationDTO> educationDTOs = new List<EducationDTO>();
			foreach (var education in educations)
			{
				educationDTOs.Add(DTOMapping.DTOMapping.ToEducationDTO(education));
			}
			return educationDTOs;
		}
	}
}
