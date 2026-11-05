using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dominio;

namespace PrubebaTecnica.Api.Controllers;

[ApiController]
public abstract class BaseApiController : ControllerBase
{
    protected IActionResult HandleFailure(Error error)
    {
        var statusCode = error.type switch
        {
            ErrorTypes.Validation => StatusCodes.Status400BadRequest,
            ErrorTypes.NotFound   => StatusCodes.Status404NotFound,
            ErrorTypes.Conflict   => StatusCodes.Status409Conflict,
            _                    => StatusCodes.Status500InternalServerError
        };

        return Problem(statusCode: statusCode, title: error.code, detail: error.message);
    }
}