using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		[StringLength(30)]
		public String Name { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}