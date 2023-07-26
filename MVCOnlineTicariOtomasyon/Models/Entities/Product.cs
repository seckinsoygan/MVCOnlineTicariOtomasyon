using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string ProductName { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string Brand { get; set; }
		public int Stock { get; set; }
		public decimal BuyingPrice { get; set; }
		public decimal SellingPrice { get; set; }
		public bool Status { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(250)]
		public string ProductImage { get; set; }
		public Category Category { get; set; }
		public SalesMovements SalesMovements { get; set; }
	}
}