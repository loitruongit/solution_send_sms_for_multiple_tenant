using solution_send_sms_for_multiple_tenant.Constants;
using solution_send_sms_for_multiple_tenant.DesignPatterns.TemplateMethod;
using solution_send_sms_for_multiple_tenant.Interfaces;

namespace solution_send_sms_for_multiple_tenant.Services.ProviderA
{
    public class TenantASMSService : BaseProviderAService
    {
        private readonly IClientCredentialsFactory _clientCredentialsFactory;
        private readonly IHttpClientFactory _httpClientFactory;
        public TenantASMSService(IClientCredentialsFactory clientCredentialsFactory, IHttpClientFactory httpClientFactory)
        {
            _clientCredentialsFactory = clientCredentialsFactory;
            _httpClientFactory = httpClientFactory;
        }

        public override string SenderName => SenderConstants.TENANT_A;

        protected override async Task<string> GetAccessToken()
        {
            //Get token for tenant A
            var _httpClient = _httpClientFactory.CreateClient();
            var (clientId, clientSecret) = _clientCredentialsFactory.GetClientCredentials(SenderName);
            //_httpClient.DefaultRequestHeaders.Authorization = new BasicAuthenticationHeaderValue(clientId, clientSecret);

            //....... TODO
            return string.Empty;
        }
    }
}
