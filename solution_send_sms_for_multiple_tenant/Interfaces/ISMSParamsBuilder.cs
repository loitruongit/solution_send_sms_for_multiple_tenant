using solution_send_sms_for_multiple_tenant.Requests;

namespace solution_send_sms_for_multiple_tenant.Interfaces
{
    public interface ISMSParamsBuilder
    {
        bool IsMatch(string smsTypeCode);

        Dictionary<string, dynamic> BuildParams(DetailsSMSRequest request);
    }
}
