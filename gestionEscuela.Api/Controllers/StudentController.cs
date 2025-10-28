using gestionEscuela.Application.Services;
using gestionEscuela.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace gestionEscuela.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly StudentService _studentService;

    public StudentController(StudentService studentService)
    {
        _studentService = studentService;
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Student student)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdStudent = await _studentService.CreateAsync(student);
        return CreatedAtAction(nameof(GetType), new { id = createdStudent.Id }, createdStudent);
    }
}