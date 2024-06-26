using solution_send_sms_for_multiple_tenant.Constants;
using solution_send_sms_for_multiple_tenant.Interfaces;

namespace solution_send_sms_for_multiple_tenant.DesignPatterns.FactoryMethod
{
    public class ClientCredentialsFactory : IClientCredentialsFactory
    {
        /// <summary>
        /// Get client credentials
        /// </summary>
        /// <param name="senderName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public (string ClientId, string ClientSecret) GetClientCredentials(string senderName)
        {
            return senderName switch
            {
                SenderConstants.TENANT_A => ("ClientId_A", "ClientSecret_A"),
                SenderConstants.TENANT_B => ("ClientId_B", "ClientSecret_B"),
                SenderConstants.TENANT_C => ("ClientId_C", "ClientSecret_C"),
                SenderConstants.TENANT_D => ("ClientId_D", "ClientSecret_D"),
                _ => throw new ArgumentException("Invalid sender name", nameof(senderName))
            };
        }
    }
}
