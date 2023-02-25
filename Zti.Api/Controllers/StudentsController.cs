using Microsoft.AspNetCore.Mvc;
using Zti.Api.Services;
using Zti.Common;

namespace Zti.Api.Controllers;

[ApiController]
public class StudentsController : ControllerBase
{
	private readonly IStudentService _studentService;

	public StudentsController(IStudentService studentService)
	{
		_studentService = studentService;
	}
	
	
	[HttpGet]
	[Route("students")]
	public IActionResult GetStudents()
	{
		var students = _studentService.GetStudents();
		return students != null ? Ok(students) : NotFound();
	}
}