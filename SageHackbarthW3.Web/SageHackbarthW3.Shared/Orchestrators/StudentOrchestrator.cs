using SageHackbarthW3.Domain;
using SageHackbarthW3.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SageHackbarthW3.Shared.Orchestrators
{
	public class StudentOrchestrator
	{
		private readonly SchoolContent _schoolContext;

		public StudentOrchestrator()
		{
			_schoolContext = new SchoolContent();
		}

		public List<StudentViewModel> GetAllStudents()
		{
			var students = _schoolContext.Students.Select(x => new StudentViewModel {
				StudentName = x.StudentName, DateOfBirth = x.DateOfBirth, Height = x.Height, Weight = x.Weight
			}).ToList();

			return students;
		}
	}
}
