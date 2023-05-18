using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface ICameraVideoService
{
    /// <summary>
    /// Convert the received lens capability object into lens data transfer object.
    /// </summary>
    /// <param name="receiver">receiver</param>
    /// <returns></returns>
    Task<CapacityVideo> ReceiverAsync(CapacityVideoReceiver receiver);
}
