﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Dtos
{
	public class AddBlogDto
	{
		public string Name { get; set; }
		public string Description { get; set; }		
		public int CategoryId { get; set; }
		public string ImagePath { get; set; }
	}
}