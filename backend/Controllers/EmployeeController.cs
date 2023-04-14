using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectsManagement.Models;

namespace ProjectsManagement.Controllers;

[ApiController]
[Authorize]
public class EmployeeController : ControllerBase
{

    [AllowAnonymous]
    [HttpGet("/v1/employees")]
    public async Task<IActionResult> Get() { return null; }


    [HttpGet("/v1/employees/{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id) { return null; }



    [HttpPost("/v1/employees")]
    public async Task<IActionResult> Post(Employee dto) { return null; }



    [HttpPatch("/v1/employees/{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Employee dto) { return null; }



    [HttpDelete("/v1/employees/{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id) { return null; }

}