using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Classes
{
	public class BillItem
	{
		[Key]
		public int BillItemId { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(100)]
		public string Description { get; set; }
		public int Miktar { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Tutar { get; set; }
		public Bill Bill { get; set; }
	}
}