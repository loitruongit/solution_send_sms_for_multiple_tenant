using solution_send_sms_for_multiple_tenant.Constants;

namespace solution_send_sms_for_multiple_tenant.Services.ProviderB
{
    public class TenantCSMSService : BaseProviderBService
    {
        public TenantCSMSService()
        {

        }

        public override string SenderName => SenderConstants.TENANT_C;

        protected override async Task<string> GetAccessToken()
        {
            //Get token for tenant A

            return string.Empty;
        }
    }
}
