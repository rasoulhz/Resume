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
	public class ProjectService : IProjectService
	{
		private readonly IProjectRepository _projectRepository;

		public ProjectService(IProjectRepository projectRepository)
        {
			_projectRepository = projectRepository;
		}
        public async Task<List<ProjectDTO>> GetAllProjectDTOs()
		{
			List<Project> projects = await _projectRepository.GetAllProjects();
			List<ProjectDTO> projectDTOs = new List<ProjectDTO>();
			foreach (var project in projects)
			{
				projectDTOs.Add(DTOMapping.DTOMapping.ToProjectDTO(project));
			}
			return projectDTOs;
		}
	}
}
