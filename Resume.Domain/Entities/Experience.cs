using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities
{
	public class Experience
	{
		public int Id { get; set; }
		[MaxLength(4)]
		public string EntryDate { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
		public string Description { get; set; }

	}
}
