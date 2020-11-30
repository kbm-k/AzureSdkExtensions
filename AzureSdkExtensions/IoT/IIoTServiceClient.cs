using System.Threading.Tasks;
using Microsoft.Azure.Devices;

namespace AzureSdkExtensions.IoT
{
    public interface IIoTServiceClient
    {
        Task SendAsync(string hostId, Message commandMessage);
    }
}