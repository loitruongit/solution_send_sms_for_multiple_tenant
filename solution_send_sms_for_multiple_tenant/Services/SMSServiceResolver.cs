using solution_send_sms_for_multiple_tenant.Interfaces;
using solution_send_sms_for_multiple_tenant.Services.FakeProvider;

namespace solution_send_sms_for_multiple_tenant.Services
{
    public class SMSServiceResolver : ISMSServiceResolver
    {
        private readonly List<string> DevPhoneNumbers = new List<string>
        {
            "0XXXXXXXXXXX",
            "0XXXXXXXXXXX",
            "0XXXXXXXXXXX"
        };

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IServiceProvider _serviceProvider;
        public SMSServiceResolver(IWebHostEnvironment webHostEnvironment, IServiceProvider serviceProvider)
        {
            _webHostEnvironment = webHostEnvironment;
            _serviceProvider = serviceProvider;
        }

        public ISMSService Resolve(string phoneNumber, string senderName)
        {

            IEnumerable<ISMSService> zaloNotificationServices = _serviceProvider.GetServices<ISMSService>();

            if (_webHostEnvironment.IsProduction() || DevPhoneNumbers.Contains(phoneNumber))
            {
                return zaloNotificationServices.First(x => x.SenderName.Equals(senderName));
            }
            else
            {
                return zaloNotificationServices.First(x => x.SenderName.Equals(nameof(FakeSMSService)));
            }
        }
    }
}
