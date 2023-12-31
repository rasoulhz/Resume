﻿using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.appDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {      
        }
        public DbSet<PersonalInformation> PersonalInformation { get; set; }
        public DbSet<AboutMe> aboutMes { get; set; }
		public DbSet<Experience> experiences { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<ContactMe> contactMes { get; set; }
	}
}
