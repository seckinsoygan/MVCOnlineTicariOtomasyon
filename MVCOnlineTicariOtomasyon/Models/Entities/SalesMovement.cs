using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
	public class SalesMovement
	{
		[Key]
		public int SalesId { get; set; }
		public DateTime Date { get; set; }
		public int Amount { get; set; }
		public decimal Price { get; set; }
		public decimal TotalAmount { get; set; }
		public Product Products { get; set; }
		public Current Currents { get; set; }
		public Employee Employees { get; set; }
	}
}