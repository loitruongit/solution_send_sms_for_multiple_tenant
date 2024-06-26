using solution_send_sms_for_multiple_tenant.Interfaces;
using solution_send_sms_for_multiple_tenant.Requests;

namespace solution_send_sms_for_multiple_tenant.Services.FakeProvider
{
    public class FakeSMSService : ISMSService
    {
        public FakeSMSService()
        {

        }

        public string SenderName => nameof(FakeSMSService);
        public async Task<bool> SendAsync(DetailsSMSRequest request, string znsType)
        {
            //Send Email

            return true;
        }
    }
}
