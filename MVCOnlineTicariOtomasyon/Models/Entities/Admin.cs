﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
	public class Admin
	{
		[Key]
		public int AdminId { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(10)]
		public string Nickname { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string Password { get; set; }
		[Column(TypeName = "Char")]
		[StringLength(1)]
		public string Authority{ get; set; }
	}
}