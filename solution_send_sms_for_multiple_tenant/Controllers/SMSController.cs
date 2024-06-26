using MediatR;
using Microsoft.AspNetCore.Mvc;
using solution_send_sms_for_multiple_tenant.Requests;
using solution_send_sms_for_multiple_tenant.SmsNotifications.TenantA;

namespace solution_send_sms_for_multiple_tenant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SMSController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SMSController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("tenant-a/send")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> SendZnsForTenantAAsync([FromBody] DetailsSMSRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new SendSmsForTenantACommand(request));
        }
    }
}
