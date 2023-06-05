using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerCore.DTOs;

namespace NLayer.API.Controllers
{
   
    public class CustomBaseController : ControllerBase
    {
        [NonAction] //endpoint olmadığını ifade eder
        public IActionResult CreateActionResult<T> (CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
