using System.Threading.Tasks;
using Microsoft.Azure.Devices;

namespace AzureSdkExtensions.IoT
{
    /// <summary>
    /// Azure.ServiceClient class doesn't have a parameterless constructor,
    /// so we need a wrapper to mock in unit tests.
    /// </summary>
    public class IoTServiceClient : IIoTServiceClient
    {
        private readonly ServiceClient _serviceClient;

        public IoTServiceClient(string connectionString) => _serviceClient = ServiceClient.CreateFromConnectionString(connectionString);

        public async Task SendAsync(string hostId, Message commandMessage) => await _serviceClient.SendAsync(hostId, commandMessage);
    }
}
