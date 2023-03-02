using FreeCourse.Services.Order.Application.Commands;
using FreeCourse.Services.Order.Application.Queries;
using FreeCourse.Shared.ControllerBases;
using FreeCourse.Shared.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Services.Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : CustomBaseController
    {
        private readonly IMediator _mediator;
        private readonly ISharedIdentityService _sharedIdentityService;

        public OrderController(IMediator mediator, ISharedIdentityService sharedIdentityService)
        {
            _mediator = mediator;
            _sharedIdentityService = sharedIdentityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var response = await _mediator.Send(new GetOrdersByUserIdQuery { UserId = _sharedIdentityService.GetUserId });

            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrder(CreateOrderCommand createOrderCommand)
        {
            var response = await _mediator.Send(createOrderCommand);

            return CreateActionResultInstance(response);
        }

    }
}
