using MediatR;
using solution_send_sms_for_multiple_tenant.Constants;
using solution_send_sms_for_multiple_tenant.Interfaces;
using solution_send_sms_for_multiple_tenant.Requests;

namespace solution_send_sms_for_multiple_tenant.SmsNotifications.TenantA
{
    public class SendSmsForTenantACommand : IRequest<bool>
    {
        public DetailsSMSRequest Parameter { get; set; }

        public SendSmsForTenantACommand(DetailsSMSRequest parameter)
        {
            Parameter = parameter;
        }
    }

    public class SendSmsForTenantACommandHandler : IRequestHandler<SendSmsForTenantACommand, bool>
    {
        private readonly IEnumerable<ISMSParamsBuilder> _sMSParamsBuilders;
        private readonly ISMSServiceResolver _serviceResolver;
        public SendSmsForTenantACommandHandler(IEnumerable<ISMSParamsBuilder> sMSParamsBuilders, ISMSServiceResolver serviceResolver)
        {
            _sMSParamsBuilders = sMSParamsBuilders;
            _serviceResolver = serviceResolver;
        }

        public async Task<bool> Handle(SendSmsForTenantACommand request, CancellationToken cancellationToken)
        {
            var smsParameters = _sMSParamsBuilders.FirstOrDefault(x => x.IsMatch(request.Parameter.SMSTypeCode));
            if (smsParameters is null)
            {
                //log
            }

            var smsService = _serviceResolver.Resolve(request.Parameter.PhoneNumber, request.Parameter.SMSTypeCode);
            if (smsService is null)
            {
                //log
            }

            await smsService.SendAsync(request.Parameter, SenderConstants.TENANT_A);

            return true;
        }
    }
}
