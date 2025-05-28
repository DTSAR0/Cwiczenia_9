using APBD_EF_CodeFirst_Example.DTOs;
using APBD_EF_CodeFirst_Example.Exceptions;
using APBD_EF_CodeFirst_Example.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_EF_CodeFirst_Example.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController(IDbService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetStudentsDetails()
    {
        return Ok(await service.GetStudentsDetailsAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetStudentDetails([FromRoute] int id)
    {
        try
        {
            return Ok(await service.GetStudentDetailsByIdAsync(id));
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> AddStudent([FromBody] StudentCreateDto studentData)
    {
        try
        {
            var student = await service.CreateStudentAsync(studentData);
            return CreatedAtAction(nameof(GetStudentDetails), new { id = student.Id }, student);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent([FromRoute] int id, [FromBody] StudentUpdateDto studentData)
    {
        try
        {
            await service.UpdateStudentAsync(id, studentData);
            return NoContent();
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent([FromRoute] int id)
    {
        try
        {
            await service.RemoveStudentAsync(id);
            return NoContent();
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}