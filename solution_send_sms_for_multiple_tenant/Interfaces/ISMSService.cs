using solution_send_sms_for_multiple_tenant.Requests;

namespace solution_send_sms_for_multiple_tenant.Interfaces
{
    public interface ISMSService
    {
        string SenderName { get; }

        Task<bool> SendAsync(DetailsSMSRequest request, string znsType);
    }
}
