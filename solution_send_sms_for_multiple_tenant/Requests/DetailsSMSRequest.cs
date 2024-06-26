namespace solution_send_sms_for_multiple_tenant.Requests
{
    public class DetailsSMSRequest
    {
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string SMSTypeCode { get; set; }
        public string Otp { get; set; }
        public string DynamicLink { get; set; }

    }
}
