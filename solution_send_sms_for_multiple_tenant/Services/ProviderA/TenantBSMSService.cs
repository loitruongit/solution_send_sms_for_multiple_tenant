using solution_send_sms_for_multiple_tenant.Constants;
using solution_send_sms_for_multiple_tenant.DesignPatterns.TemplateMethod;

namespace solution_send_sms_for_multiple_tenant.Services.ProviderA
{
    public class TenantBSMSService : BaseProviderAService
    {
        public TenantBSMSService()
        {

        }

        public override string SenderName => SenderConstants.TENANT_B;

        protected override async Task<string> GetAccessToken()
        {
            //Get token for tenant A

            return string.Empty;
        }
    }
}
