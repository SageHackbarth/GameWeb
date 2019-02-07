using System;
using System.ComponentModel.DataAnnotations;

namespace SageHackbarthW3.Domain.Entities
{
	public class Student
	{
		public Guid StudentId { get; set; }
		[StringLength(50)]
		public string StudentName { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public decimal Height { get; set; }
		public float Weight { get; set; }
	}
}
