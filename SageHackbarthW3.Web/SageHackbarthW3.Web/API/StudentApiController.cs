using SageHackbarthW3.Shared.Orchestrators;
using SageHackbarthW3.Shared.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace SageHackbarthW3.Web.API
{
	[Route("api/v1/students")]
	public class StudentApiController : ApiController
    {
		private readonly StudentOrchestrator _studentOrchestrator;
		public StudentApiController()
		{
			_studentOrchestrator = new StudentOrchestrator();
		}

		[HttpGet]
		public List<StudentViewModel> GetAllStudents()
		{
			var students = _studentOrchestrator.GetAllStudents();

			return students;
		}
    }
}
