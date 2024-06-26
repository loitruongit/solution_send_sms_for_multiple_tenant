using solution_send_sms_for_multiple_tenant.Constants;

namespace solution_send_sms_for_multiple_tenant.Services.ProviderB
{
    public class TenantDSMSService : BaseProviderBService
    {
        public TenantDSMSService()
        {

        }

        public override string SenderName => SenderConstants.TENANT_D;

        protected override async Task<string> GetAccessToken()
        {
            //Get token for tenant A

            return string.Empty;
        }
    }
}
