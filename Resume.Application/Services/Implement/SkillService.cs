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
	public class SkillService : ISkillService
	{
		private readonly ISkillRepository _skillRepository;

		public SkillService(ISkillRepository skillRepository)
        {
			_skillRepository = skillRepository;
		}
        public async Task<List<SkillDTO>> GetAllSkillDTOs()
		{
			List<Skill> skills = await _skillRepository.GetAllSkills();
			List<SkillDTO> skillDTOs = new List<SkillDTO>();
			foreach (var skill in skills)
			{
				skillDTOs.Add(DTOMapping.DTOMapping.ToSkillDTO(skill));
			}
			return skillDTOs;
		}
	}
}
