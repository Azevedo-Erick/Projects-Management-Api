using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectsManagement.Models;

namespace ProjectsManagement.Controllers;

[ApiController]
[Authorize]
public class PermissionController : ControllerBase
{

    [AllowAnonymous]
    [HttpGet("/v1/permissions")]
    public async Task<IActionResult> Get() { return null; }


    [HttpGet("/v1/permissions/{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id) { return null; }



    [HttpPost("/v1/permissions")]
    public async Task<IActionResult> Post(Permission dto) { return null; }



    [HttpPatch("/v1/permissions/{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Permission dto) { return null; }



    [HttpDelete("/v1/permissions/{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id) { return null; }

}