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


    [HttpGet("getbyid/{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var student = await _studentService.GetByIdAsync(id);

        if (student == null)
            return NotFound(new { message = $"Student with ID {id} not found." });

        return Ok(student);
    }


    

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] Student student)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdStudent = await _studentService.CreateAsync(student);
        return CreatedAtAction(nameof(GetById), new { id = createdStudent.Id }, createdStudent);
    }
}