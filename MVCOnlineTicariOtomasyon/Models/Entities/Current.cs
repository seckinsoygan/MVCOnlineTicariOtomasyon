using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
	public class Current
	{
		[Key]
		public int CurrentId { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(10)]
		public string CurrentName { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(10)]
		public string CurrentSurname { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(13)]
		public string CurrentCity { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(50)]
		public string CurrentMail { get; set; }
		public ICollection<SalesMovement> SalesMovements { get; set; }
	}
}