using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
	public class Bill
	{
		[Key]
		public int BillId { get; set; }
		[Column(TypeName = "Char")]
		[StringLength(1)]
		public char BillSeriNo { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(6)]
		public string BillSıraNo { get; set; }
		public DateTime BillDateTime { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(60)]
		public string TaxAdministrator { get; set; }
		public DateTime Time { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string Submitter { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string Receiver { get; set; }
		public ICollection<BillItem> BillItems { get; set; }
	}

}