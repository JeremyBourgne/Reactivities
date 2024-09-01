using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        // If it is null we take the line at the right
        protected IMediator Mediator => _mediator ??= 
            HttpContext.RequestServices.GetService<IMediator>();
    }
}
