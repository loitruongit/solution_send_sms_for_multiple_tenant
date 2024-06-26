namespace solution_send_sms_for_multiple_tenant.Interfaces
{
    public interface IClientCredentialsFactory
    {
        (string ClientId, string ClientSecret) GetClientCredentials(string senderName);
    }
}
