using solution_send_sms_for_multiple_tenant.Interfaces;
using solution_send_sms_for_multiple_tenant.Requests;

namespace solution_send_sms_for_multiple_tenant.DesignPatterns.TemplateMethod
{
    public abstract class BaseProviderAService : ISMSService
    {
        public BaseProviderAService()
        {

        }

        public abstract string SenderName { get; }

        protected abstract Task<string> GetAccessToken();

        public async Task<bool> SendAsync(DetailsSMSRequest request, string znsType)
        {
            //Send SMS with provider A

            return true;
        }
    }
}
