namespace solution_send_sms_for_multiple_tenant.Interfaces
{
    public interface ISMSServiceResolver
    {
        ISMSService Resolve(string phoneNumber, string senderName);
    }
}
