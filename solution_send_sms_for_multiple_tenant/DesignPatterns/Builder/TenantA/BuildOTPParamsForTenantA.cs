using solution_send_sms_for_multiple_tenant.Constants;
using solution_send_sms_for_multiple_tenant.Interfaces;
using solution_send_sms_for_multiple_tenant.Requests;

namespace solution_send_sms_for_multiple_tenant.DesignPatterns.Builder.TenantA
{
    public class BuildOTPParamsForTenantA : ISMSParamsBuilder
    {

        public bool IsMatch(string smsTypeCode)
        {
            return SMSTypeCode.TENANT_A_TEMPLATE_OTP == smsTypeCode;
        }

        public Dictionary<string, dynamic> BuildParams(DetailsSMSRequest request)
        {
            var smsParameters = new Dictionary<string, dynamic>
            {
                ["Otp"] = request.Otp,
                ["DynamicLink"] = request.DynamicLink
            };

            return smsParameters;
        }
    }
}
