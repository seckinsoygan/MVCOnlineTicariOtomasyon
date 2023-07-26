﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
	public class Employee
	{
		[Key]
		public int EmployeeId { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string EmployeeName { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string EmployeeSurname { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(250)]
		public string EmployeeImage { get; set; }
		public SalesMovements SalesMovements { get; set; }
		public Department Department { get; set; }
	}
}